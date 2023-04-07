using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public GameObject homebttn;
    public Vector3 homebttnPos;
    public GameObject retrybttn;
    public Vector3 retrybttnPos;
    public GameObject gameOver;
    public Vector3 gameOverPos;
    public GameObject highScore;
    public Vector3 highScorePos;
    public Text highScoreNum;
    public Vector3 highScoreNumPos;

    private float prevScore = 0f;
    private int totalCoins = 0;
    private const string HIGHSCORE_KEY = "highscore";
    private const string COINS_KEY = "coins";

    void Start() {
        // Load the highscore from PlayerPrefs on startup
        prevScore = PlayerPrefs.GetFloat(HIGHSCORE_KEY, 0);
        totalCoins = PlayerPrefs.GetInt(COINS_KEY, 0);
    }

    private void Update() {
        if(PauseController.isPaused) {
            homebttn.transform.position = homebttnPos;
            retrybttn.transform.position = retrybttnPos;
            gameOver.transform.position = gameOverPos;
            highScore.transform.position = highScorePos;
            highScoreNum.transform.position = highScoreNumPos;

            float distance = float.Parse(GameObject.Find("Distance").GetComponent<UnityEngine.UI.Text>().text);
            UpdateHighScore(distance);
            highScoreNum.text = prevScore + "";

            int coins = int.Parse(GameObject.Find("ScoreBoard").GetComponent<UnityEngine.UI.Text>().text);
            UpdateCoins(coins);
        }
    }

    private void UpdateHighScore(float score) {
        if (score > prevScore) {
            prevScore = score;
            PlayerPrefs.SetFloat(HIGHSCORE_KEY, prevScore);
        }
    }

    private void UpdateCoins(int coins) {
            totalCoins += coins;
            PlayerPrefs.SetInt(COINS_KEY, totalCoins);
    }
}
