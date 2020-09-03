using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class DeathPlain : MonoBehaviour
{
    public Transform player;
    public Transform PlayerSpawn;
    DbManager dataMgr = DbManager.Instance;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            player.transform.position = PlayerSpawn.transform.position;
            Health.PlayerLives--;
            dataMgr.dbHealth = Health.PlayerHealth;
            dataMgr.dbLives = Health.PlayerLives;
            dataMgr.dbCoins = Coin.PlayerCoins;
            dataMgr.dbLocation = SceneManager.GetActiveScene().name;
            string jsonString = JsonUtility.ToJson(dataMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json",jsonString);
        }
    }
}
