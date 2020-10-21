using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 0;
    float highScore;
    float ranking, ranking1 = 50.0f, ranking2 = 40.0f, ranking3 = 30.0f, ranking4 = 20.0f, ranking5 = 10.0f;

    [SerializeField] TextMeshProUGUI UIScore;
    [SerializeField] TextMeshProUGUI UIHighScore;
    [SerializeField] TextMeshProUGUI UIRanking;
    [SerializeField] TextMeshProUGUI UIRanking1;
    [SerializeField] TextMeshProUGUI UIRanking2;
    [SerializeField] TextMeshProUGUI UIRanking3;
    [SerializeField] TextMeshProUGUI UIRanking4;
    [SerializeField] TextMeshProUGUI UIRanking5;


    void Awake()
    {
        // Load Score and Ranking
        highScore = PlayerPrefs.GetFloat("highScore");
        ranking1 = PlayerPrefs.GetFloat("highScore");
        ranking2 = PlayerPrefs.GetFloat("ranking2");
        ranking3 = PlayerPrefs.GetFloat("ranking3");
        ranking4 = PlayerPrefs.GetFloat("ranking4");
        ranking5 = PlayerPrefs.GetFloat("ranking5");

        //Turn Off the Ranking Board
        UIRanking.gameObject.SetActive(false);
        UIRanking1.gameObject.SetActive(false);
        UIRanking2.gameObject.SetActive(false);
        UIRanking3.gameObject.SetActive(false);
        UIRanking4.gameObject.SetActive(false);
        UIRanking5.gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        //Score UI
        currentTime += 1 * Time.deltaTime;
        UIScore.text = "Score: " + currentTime.ToString("0");

        //Ranking Score UI
        UIHighScore.text = "High Score: " + highScore.ToString("0");
        UIRanking.text = "RANKING";
        UIRanking1.text = "1st          " + ranking1.ToString("0");
        UIRanking2.text = "2nd          " + ranking2.ToString("0");
        UIRanking3.text = "3rd          " + ranking3.ToString("0");
        UIRanking4.text = "4th          " + ranking4.ToString("0");
        UIRanking5.text = "5th          " + ranking5.ToString("0");
        
        //High Score Save to temporary database in Unity.
        if (currentTime > highScore)
        {
            highScore = currentTime;
            PlayerPrefs.SetFloat("highScore", highScore);
            PlayerPrefs.SetFloat("ranking1", highScore);
        }
        else if (highScore > currentTime && currentTime > ranking2)
        {
            ranking2 = currentTime;
            PlayerPrefs.SetFloat("ranking2", ranking2);
        }
        else if (ranking2 > currentTime && currentTime > ranking3)
        {
            ranking3 = currentTime;
            PlayerPrefs.SetFloat("ranking3", ranking3);
        }
        else if (ranking3 > currentTime && currentTime > ranking4)
        {
            ranking4 = currentTime;
            PlayerPrefs.SetFloat("ranking4", ranking4);
        }
        else if (ranking4 > currentTime && currentTime > ranking5)
        {
            ranking5 = currentTime;
            PlayerPrefs.SetFloat("ranking5", ranking5);
        }
        
        if (Time.timeScale == 0)
        {
            UIRanking.gameObject.SetActive(true);
            UIRanking1.gameObject.SetActive(true);
            UIRanking2.gameObject.SetActive(true);
            UIRanking3.gameObject.SetActive(true);
            UIRanking4.gameObject.SetActive(true);
            UIRanking5.gameObject.SetActive(true);
        }
    }
}


