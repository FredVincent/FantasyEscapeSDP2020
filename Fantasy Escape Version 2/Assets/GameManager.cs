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
    public float score;
    public float highScore;
    public TextMeshProUGUI UIScore;
    public TextMeshProUGUI UIHighScore;
    public Vector3 respawnPos;

    void Start()
    {
        respawnPos = new Vector3(0,0,0);

        if (SaveManager.instance.hasLoaded)
        {
            respawnPos = SaveManager.instance.activeSave.respawnPos;
            


        }
    }
    
    //All Those Code is included in 'CountDown' Script 
    //void Awake()
    //{
    //    // Load High Score
    //    highScore = PlayerPrefs.GetFloat("highScore");
    //}
    //void Update()
    //{
        //Score UI
        //UIScore.text = "Score: " + score.ToString();
        //High Score UI
        //UIHighScore.text = "High Score: " + highScore.ToString();

        //High Score Save to temporary database in Unity.
        //if (score > highScore)
        //{
        //    highScore = score;
        //    PlayerPrefs.SetFloat("highScore", highScore);
        //}
    //}
}
