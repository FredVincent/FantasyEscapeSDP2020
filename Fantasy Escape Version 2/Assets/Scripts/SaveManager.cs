using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;
    public SaveData activeSave;
    public bool hasLoaded;

    private void Awake()
    {
        instance = this;
        Load();
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) 
        {
            Save();
        }

        if (Input.GetKeyDown(KeyCode.X)) 
        {
            Load();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            DeleteSave();
        }
    }

    public void Save()
    {
        string dPath = Application.persistentDataPath;

        var serializer = new XmlSerializer(typeof(SaveData));
        var Stream = new FileStream(dPath + "/" + activeSave.saveName + ".save", FileMode.Create);
        serializer.Serialize(Stream, activeSave);
        Stream.Close();

        Debug.Log("Saved!!");
    }

    public void Load()
    {
        string dPath = Application.persistentDataPath;

        if (System.IO.File.Exists(dPath + "/" + activeSave.saveName + ".save")) ;
        {
            var serializer = new XmlSerializer(typeof(SaveData));
            var Stream = new FileStream(dPath + "/" + activeSave.saveName + ".save", FileMode.Open);
            activeSave = serializer.Deserialize(Stream) as SaveData;

            Stream.Close();

            Debug.Log("Loaded!!");
        }

        hasLoaded = true;
    }

    public void DeleteSave()
    {
        string dPath = Application.persistentDataPath;
        if (System.IO.File.Exists(dPath + "/" + activeSave.saveName + ".save")) ;
        {
            File.Delete(dPath + "/" + activeSave.saveName + ".save");

            Debug.Log("Deleted!!");
        }

    }
}

[System.Serializable]
public class SaveData
{
    public string saveName;
    public int points;
    public Vector3 respawnPos;
}
