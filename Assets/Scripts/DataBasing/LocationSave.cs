using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LocationSave : MonoBehaviour
{
    DbManager dataMgr = DbManager.Instance;
    void Start()
    {
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager load = JsonUtility.FromJson<DbManager>(fromJson);
        dataMgr.dbHealth = load.dbHealth;
        dataMgr.dbLives = Health.PlayerLives;
         dataMgr.dbCoins = Coin.PlayerCoins;
         dataMgr.dbLocation = SceneManager.GetActiveScene().name;
         string jsonString = JsonUtility.ToJson(dataMgr);
         File.WriteAllText(Application.dataPath + "PlayerSaveData.json",jsonString);
    }


}
