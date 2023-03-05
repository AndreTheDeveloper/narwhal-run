using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{
   public float jumpForce = 10f;
    public float fallDelay = 0.5f;
    public Rigidbody2D rb;
    public BoxCollider2D collider;

    private bool isJumping = false;
    private Vector2 startingPosition;
    private float lastJumpTime;

    void Start()
    {
        startingPosition = transform.position;
        lastJumpTime = Time.time;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !isJumping)
        {
            // Jump when the screen is touched
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isJumping = true;
            lastJumpTime = Time.time;
        }
    }

    void FixedUpdate()
    {
        if (isJumping && Time.time - lastJumpTime > fallDelay)
        {
            // Set the object's velocity to zero when falling down
            rb.velocity = Vector2.zero;
            if (transform.position.y > startingPosition.y)
            {
                // Move the object down towards the starting position
                transform.position = Vector2.MoveTowards(transform.position, startingPosition, Time.deltaTime * 10f);
            }
            else
            {
                // Object has reached the starting position
                isJumping = false;
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            isJumping = false;
        }
    }
}
