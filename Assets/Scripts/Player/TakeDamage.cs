using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class TakeDamage : MonoBehaviour
{
    public DbManager dbMgr = DbManager.Instance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            dbMgr.dbHealth--;
            dbMgr.dbLives = Health.PlayerLives;
            dbMgr.dbCoins = Coin.PlayerCoins;
            string tojson = JsonUtility.ToJson(dbMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json",tojson);
            Health.PlayerHealth--;
        }
    }
}
