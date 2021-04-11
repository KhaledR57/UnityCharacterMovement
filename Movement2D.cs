using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 direction;
    public Transform legs;
    public LayerMask ground;

    public float speed = 2f;
    public float radius = 0.3f;
    public float jumpForce = 7f;
    public float jumpTime = 0.3f;

    private float _temp;
    private bool _onTheGround;



    private void Start()
    {
        _temp = jumpTime;
    }

    private void Update()
    {
        direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        // Left and Right
        rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);

        // To Check If The Character Is On The Ground
        _onTheGround = Physics2D.OverlapCircle(legs.position, radius, ground);

        // To Check If The Jump Button Is Pressed And The Player Is On The Ground
        if (_onTheGround && direction.y > 0)
        {
            rb.AddForce(new Vector2(0f, jumpForce));
            jumpTime = _temp;
        }

        // Make Jump Higher By Pressing Longer
        if (direction.y > 0 && jumpTime > 0)
        {
            rb.AddForce(new Vector2(0f, 20));
            jumpTime -= Time.deltaTime;
        }
    }
}