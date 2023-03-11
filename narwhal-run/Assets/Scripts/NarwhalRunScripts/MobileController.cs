using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Threading;
using TMPro;

public class MobileController : MonoBehaviour
{
   private bool isJumping = false;
    private Vector2 startingPosition;
    public float jumpHeight = 5f;
    public float jumpDuration = 0.5f;
    private float jumpTimer = 0f;
    private float tiltAngle = 0f;
    private Rigidbody2D rb;
    private float timeInAir = 0f;
    public TextMeshProUGUI textMesh; // Assign this in the inspector to the TextMeshPro component you want to increment
    public string tagToDetect = ""; // Assign this in the inspector to the tag you want to detect collisions with

    private int collisionCount = 0;

    void Start()
    {
        startingPosition = transform.position;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && !isJumping)
        {
            timeInAir = 0;
            isJumping = true;
            jumpTimer = 0f;
            tiltAngle = 45f;
        }

        if (isJumping)
        {
            float normalizedTime = jumpTimer / jumpDuration;
            float jumpPosition = Mathf.Sin(normalizedTime * Mathf.PI) * jumpHeight;
            transform.position = startingPosition + Vector2.up * jumpPosition;
            
            timeInAir += Time.deltaTime;

            if(timeInAir >= 1.251) {
                tiltAngle = -45;
            } else {
                tiltAngle = 45;
            }

            transform.rotation = Quaternion.Euler(0, 0, tiltAngle);

            jumpTimer += Time.deltaTime;

            if (jumpTimer >= jumpDuration)
            {
                isJumping = false;
                transform.position = startingPosition;
                transform.rotation = Quaternion.identity;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(tagToDetect))
        {
            collisionCount++;
            textMesh.text = collisionCount.ToString();
            
        }
    }
}
