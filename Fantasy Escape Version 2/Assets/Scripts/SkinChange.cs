using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChange : MonoBehaviour
{
    public GameObject petInfoPanel;
    public GameObject blueSkinInfoPanel;
    
    void Awake()
    {
        petInfoPanel.SetActive(false);
        blueSkinInfoPanel.SetActive(false);
    }

    public void petClicked()
    {
        blueSkinInfoPanel.SetActive(false);
        petInfoPanel.SetActive(true);
    }

    public void blueClicked()
    {
        petInfoPanel.SetActive(false);
        blueSkinInfoPanel.SetActive(true);
    }

    public void petEqu()
    {
        PlayerPrefs.SetInt("petSkin", 1);
        PlayerPrefs.Save();
    }

    public void pUnEqu()
    {
        PlayerPrefs.SetInt("petSkin", 0);
        PlayerPrefs.Save();

    }
}
