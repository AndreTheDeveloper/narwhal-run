using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Threading;

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
    public Text text;
    private int scoreCount = 0;
    private int pointsToAdd = 1;
    private float multiplyTimer = 15f;
    private bool multipler = false;
    public AudioSource audioSource;

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
        if(multipler) {
            multiplyTimer -= Time.deltaTime;
            pointsToAdd = 2;
            if (multiplyTimer <= 0f) {
                pointsToAdd = 1;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("coin"))
        {
            scoreCount += pointsToAdd;
            text.text = scoreCount.ToString();
            audioSource.Play();
        }
        else if (collision.gameObject.CompareTag("x2")) {
            multipler = true;
        }
    }
}
