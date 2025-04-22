using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isPlayerLeft = true;
    public float speed = 5f; // This is set in the inspector
    public Rigidbody2D rb; // This is set in the inspector
    private float verticalInput = 0f;
    private Vector2 startPos; // Represents the initial transform position of the gameobject

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (isPlayerLeft)
        {
            verticalInput = Input.GetAxisRaw("VerticalLeft");
        }
        else
        {
            verticalInput = Input.GetAxisRaw("VerticalRight");
        }
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, verticalInput * speed);
    }

    public void Reset()
    {
        rb.linearVelocity = Vector2.zero;
        transform.position = startPos;
    }
}
