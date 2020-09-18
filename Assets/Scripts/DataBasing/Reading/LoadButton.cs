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
        Load.onClick.AddListener(LoadLocation);
    }

    void LoadLocation()
    {
        string location = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager fromjson = JsonUtility.FromJson<DbManager>(location);
        BroSwitch.Bro = fromjson.dbBro;
        SceneManager.LoadScene(fromjson.dbLocation);
        
    }
}
