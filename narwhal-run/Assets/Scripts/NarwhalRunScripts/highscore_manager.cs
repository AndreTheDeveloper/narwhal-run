using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highscore_manager : MonoBehaviour
{
    private float highScore = 0f;

    public void UpdateHighScore(float score) {
        if (score > highScore) {
            highScore = score;
        }
    }

    public float GetHighScore() {
        return highScore;
    }
}
