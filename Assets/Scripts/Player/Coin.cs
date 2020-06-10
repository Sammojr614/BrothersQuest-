using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Coin : MonoBehaviour
{
    public GameObject Collect;
    public static int PlayerCoins;
    DbManager dbMgr = DbManager.Instance;
    void Start()
    {
        Collect.SetActive(true);
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager CoinUpdate = JsonUtility.FromJson<DbManager>(fromJson);
        PlayerCoins = CoinUpdate.dbCoins;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collect.SetActive(false);
            PlayerCoins++;
            dbMgr.dbCoins = PlayerCoins;
            dbMgr.dbHealth = Health.PlayerHealth;
            dbMgr.dbLives = Health.PlayerLives;
            string tojson = JsonUtility.ToJson(dbMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);

        }
    }

}
