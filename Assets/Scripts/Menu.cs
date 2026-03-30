using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI highscoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    public void HighScore()
    {
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        highscoreText.text = "High Score: " + highScore;
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
