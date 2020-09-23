using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

//Gmae Manager control the player score, high score and Stages.

public class GameManager : MonoBehaviour
{
    public int score;
    public int highScore;
    public TextMeshProUGUI UIScore;
    public TextMeshProUGUI UIHighScore;

    void Awake()
    {
        // Load High Score
        highScore = PlayerPrefs.GetInt("highScore");
    }
    void Update()
    {
        //Score UI
        UIScore.text = "Score: " + score.ToString();
        //High Score UI
        UIHighScore.text = "High Score: " + highScore.ToString();

        //High Score Save to temporary database in Unity.
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore", highScore);
        }
    }
}
