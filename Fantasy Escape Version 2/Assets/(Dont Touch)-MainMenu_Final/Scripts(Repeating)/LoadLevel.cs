using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLevel : MonoBehaviour
{
    [SerializeField] private string newLevel;
        public void LoadLevel()
    {
        SceneManager.LoadScene(newLevel);
    }
}
