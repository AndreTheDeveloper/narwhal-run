using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
{
    private bool isJumping = false;
    private Vector2 startingPosition;
    public float jumpHeight = 5f;
    public float jumpDuration = 0.5f;
    public float jumpTimer = 0f;

    void Start()
    {
        startingPosition = transform.position;
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !isJumping)
        {
            isJumping = true;
            jumpTimer = 0f;
        }

        if (isJumping)
        {
            float normalizedTime = jumpTimer / jumpDuration;
            float jumpForce = Mathf.Sin(normalizedTime * Mathf.PI) * jumpHeight;
            transform.position = startingPosition + Vector2.up * jumpForce;

            jumpTimer += Time.deltaTime;

            if (jumpTimer >= jumpDuration)
            {
                isJumping = false;
                transform.position = startingPosition;
            }
        }
    }
}
