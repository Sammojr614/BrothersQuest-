using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    public static int PlayerCoins;
    DbManager dbMgr = DbManager.Instance;
    public Text CurrencyCounter;
    public List<GameObject> CoinsCollect = new List<GameObject>();
    private void Update()
    {
        string fromdb = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager loadFromDb = JsonUtility.FromJson<DbManager>(fromdb);
        CurrencyCounter.text = ": " + loadFromDb.dbCurrency.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
        {
            dbMgr.dbCurrency++;
            dbMgr.dbHealth = Health.playerHealth;
            dbMgr.dbLives = Health.playerLives;
            string updateData = JsonUtility.ToJson(dbMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", updateData);
            
           
        }
    }
}
