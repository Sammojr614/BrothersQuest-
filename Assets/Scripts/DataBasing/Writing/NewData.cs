using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class NewData : MonoBehaviour
{
    public Button CreateButton;
    DbManager dataMgr = DbManager.Instance;
    void Start()
    {
        CreateButton.onClick.AddListener(CreateOnClick);
    }
    void CreateOnClick()
    {
        dataMgr.dbHealth = 2;
        dataMgr.dbLives = 4;
        dataMgr.dbCoins = 0;
        string tojson = JsonUtility.ToJson(dataMgr);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);
        SceneManager.LoadScene("Testing");
    }

  
}
