using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using UnityEngine.UI;

public class LoadButton : MonoBehaviour
{
    public Button Load;
    void Start()
    {
        if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            Load.enabled = true;
        }else if(!File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            Load.enabled = false;
        }
        Load.onClick.AddListener(LoadLocation);
    }

    void LoadLocation()
    {
        string location = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager fromjson = JsonUtility.FromJson<DbManager>(location);
        SceneManager.LoadScene(fromjson.dbLocation);
        
    }
}
