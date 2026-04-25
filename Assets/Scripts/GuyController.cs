using UnityEngine;

public class GuyController : MonoBehaviour
{
    public float jumpForce = 6f;


    private Rigidbody2D rb;
    private bool isAlive = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!isAlive) return;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        CheckBounds();
    }

    void Jump()
    {
        rb.linearVelocity = Vector2.up * jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Die();
    }

    void Die()
    {
        if (!isAlive) return;
    
        isAlive = false;
        GameManager.Instance.GameOver();
    }

    void CheckBounds()
    {
        float top = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        float bottom = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;    

        if (transform.position.y > top || transform.position.y < bottom)
        {
            Die();
        }
    }
}
