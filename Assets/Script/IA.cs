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
        if (transform.position.y > ball.transform.position.y)
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
            //Tambien podriamos: transform.position += 
        }
    }
}
