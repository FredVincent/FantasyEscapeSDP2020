using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelcompleteNew : MonoBehaviour
{  
    [SerializeField] private string newLevel;

    public void SwitchLevel()
    {
        SceneManager.LoadScene(newLevel);
    }
}
