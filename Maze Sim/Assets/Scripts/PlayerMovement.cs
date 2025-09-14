using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        rb.linearVelocity = new Vector2(horizontal * speed, vertical * speed);
    }
}
