using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI, rankTitle, rankOne, rankTwo, rankThree, rankFour, rankFive;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                rankTitle.gameObject.SetActive(false);
                rankOne.gameObject.SetActive(false);
                rankTwo.gameObject.SetActive(false);
                rankThree.gameObject.SetActive(false);
                rankFour.gameObject.SetActive(false);
                rankFive.gameObject.SetActive(false);
            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        rankTitle.gameObject.SetActive(false);
        rankOne.gameObject.SetActive(false);
        rankTwo.gameObject.SetActive(false);
        rankThree.gameObject.SetActive(false);
        rankFour.gameObject.SetActive(false);
        rankFive.gameObject.SetActive(false);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);     
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}
