using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ball, playerLeft, playerRight;
    public int leftPlayerScore, rightPlayerScore;
    public TMPro.TextMeshProUGUI playerLeftScoreText, playerRightScoreText;

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
        ReserPositions();
    }

    // This method is called to reset the ball and players to their starting positions
    private void ReserPositions()
    {
        ball.GetComponent<Ball>().Reset();
        playerLeft.GetComponent<Player>().Reset();
        playerRight.GetComponent<Player>().Reset();
    }
}
