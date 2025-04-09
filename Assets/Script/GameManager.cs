using Unity.VisualScripting;
using UnityEngine;

public class GameManager: MonoBehaviour
{
    public GameObject pelota, player1, player2; //Referencia a los objetos de la escena
    public int player1Score, player2Score; //Puntuaciones de cada jugador
    public TMPro.TextMeshProUGUI player1ScoreText, player2ScoreText;
    public void goalScored(int playerNumber)
    {
        if (playerNumber == 1)
        {
            player1Score++;
            player1ScoreText.text = player1Score.ToString();
        }
        else if (playerNumber == 2)
        {
            {
                player2Score++;
                player2ScoreText.text = player1Score.ToString();
            }
        } 
        ResetPosition();
    }
    private void ResetPosition()
    {
        pelota.GetComponent<Ball>().Reset();
        player1.GetComponent<Player>().Reset();
        player2.GetComponent<Player>().Reset();

    }

}
