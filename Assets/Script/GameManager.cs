using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball, playerLeft, playerRight;
    public int leftPlayerScore, rightPlayerScore;
    public TMPro.TextMeshProUGUI playerLeftScoreText, playerRightScoreText;

    public int maxScore = 2;
    public string winner; //This is used to store the winner of the game

    public Boolean pvp;

    private static GameManager _instance;    //This is used to make sure there is only one manager in the scene

    private void Awake()
    {
        if (_instance == null)
        {

        }
    }
    // This method is called when the ball enters the goal area (the trigger collider)
    public void GoalScored(bool isPlayerLeft)
    {
        if (isPlayerLeft)
        {
            leftPlayerScore++;
            playerLeftScoreText.text = leftPlayerScore.ToString();
        }
        else
        {
            rightPlayerScore++;
            playerRightScoreText.text = rightPlayerScore.ToString();
        }
        CheckWinner();
        ReserPositions();
    }

    private void CheckWinner()
    {
        if(leftPlayerScore >= maxScore)
        {
            Debug.Log("Player 1 Wins!");
            winner = "Player 1";
        } else if (rightPlayerScore >= maxScore && pvp)
        {
            Debug.Log("Player 2 Wins!");
            winner = "Player 2";
        }
        else if (rightPlayerScore >= maxScore && !pvp)
        {
            Debug.Log("CPU Wins!");
            winner = "CPU";
        }
    }

    public String GetWinner()
    {
        return winner;
    }

    // This method is called to reset the ball and players to their starting positions
    private void ReserPositions()
    {
        ball.GetComponent<Ball>().Reset();
        playerLeft.GetComponent<Player>().Reset();
        playerRight.GetComponent<Player>().Reset();
    }
}
