using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResetData : MonoBehaviour
{
    DbManager dbMgr = DbManager.Instance;
    public Button ResetButton;
    void Start()
    {
        ResetButton.onClick.AddListener(ThanosSnap);
    }

   void ThanosSnap()
    {
        dbMgr.dbHealth = 6;
        dbMgr.dbLives = 4;
        dbMgr.dbCoins = 0;
        string tojson = JsonUtility.ToJson(dbMgr);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json",tojson);
        SceneManager.LoadScene("Title");
    }
    
}
