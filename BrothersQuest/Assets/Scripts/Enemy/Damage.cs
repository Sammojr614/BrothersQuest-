using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Damage : MonoBehaviour
{
    DbManager dbMgr = DbManager.Instance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dbMgr.dbHealth--;
            dbMgr.dbLives = Health.playerLives;
            dbMgr.dbCurrency = 0;
            string tojson = JsonUtility.ToJson(dbMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);

        }
    }
}
