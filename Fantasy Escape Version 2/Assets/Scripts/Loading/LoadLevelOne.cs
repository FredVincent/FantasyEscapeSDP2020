using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevelOne : MonoBehaviour
{
   public void SceneSwitcherLevel01 ()
    {
        SceneManager.LoadScene("map1");
    }
}
