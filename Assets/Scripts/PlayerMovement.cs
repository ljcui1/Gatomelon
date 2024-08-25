using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private BoxCollider2D coll;
    private float dir = 0f;

    [SerializeField] private LayerMask groundLayers;

    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpSpeed = 7f;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(dir * moveSpeed, rb.velocity.y);

        if (dir > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (dir < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed);
        }

        if (transform.position.y <= -5)
        {
            Debug.Log("Dead!");
            transform.position = new Vector2(-9.053f, -3.4f);
        }
    }

    bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, groundLayers);
    }
}
