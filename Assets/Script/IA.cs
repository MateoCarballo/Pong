using UnityEngine;

public class IA : MonoBehaviour
{
    /*
     * Esta propiedad hace que una variable privada la podamos modificar desde el inspector
     */
    [SerializeField] private float speed = 5f;
    public GameObject ball;
    private Vector2 ballPosition;

    // Update is called once per frame
    void Update()
    {
        Movement(); 
    }

    public void Movement()
    {
        //Si meto esto hago que solo se mueva cuando la pelota este en el campo de la IA
        //Otra opcion seria ver que se esté moviendo hacia el jugador para no seguirla todo el rato
        if (ball.GetComponent<Rigidbody2D>().linearVelocityX > 0)
        {
            if (transform.position.y > ball.transform.position.y)
            {
                transform.Translate(Vector2.down * speed * Time.deltaTime);
                //Tambien podriamos: transform.position += 
            }

            if (transform.position.y < ball.transform.position.y)
            {
                transform.Translate(Vector2.up * speed * Time.deltaTime);
                //Tambien podriamos: transform.position += 
            }
        }
    }
}
