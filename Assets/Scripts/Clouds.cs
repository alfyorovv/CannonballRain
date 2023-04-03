using UnityEngine;

public class Clouds : MonoBehaviour
{

    public float speed = -2f; //Negative because moving left
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        gameObject.transform.localScale = new Vector2(Random.Range(1f, 1.7f), Random.Range(1f, 1.6f)); //Clouds random scale
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(1 * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag== "Delete")
        {
            Destroy(this.gameObject);
        }
    }
}
