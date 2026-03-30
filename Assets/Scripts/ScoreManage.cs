using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManage : MonoBehaviour
{
    public static ScoreManage Instance;
    public TextMeshProUGUI scoreText;
    int score = 0;
    int highScore = 0;
    private void Awake()
    {
        Instance = this;
    }
    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
        }
    }
    void UpdateUI()
    {
        scoreText.text = "Score: " + score;
    }
}
