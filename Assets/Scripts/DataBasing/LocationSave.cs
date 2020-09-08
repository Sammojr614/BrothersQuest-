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
        dataMgr.dbHealth = Health.PlayerHealth;
        dataMgr.dbLives = Health.PlayerLives;
        dataMgr.dbCoins = Coin.PlayerCoins;
        dataMgr.dbLocation = SceneManager.GetActiveScene().name;
        string jsonString = JsonUtility.ToJson(dataMgr);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json",jsonString);
    }


}
