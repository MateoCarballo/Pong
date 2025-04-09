using UnityEngine;

public class Goal : MonoBehaviour
{
    public bool isPlayer1Goal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            if (isPlayer1Goal)
            {
                FindFirstObjectByType<GameManager>().goalScored(1);
            }
            else
            {
                FindFirstObjectByType<GameManager>().goalScored(2);
            }
        }
    }
}
