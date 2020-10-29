using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CoinCollect : MonoBehaviour
{
    public static int playerCoins;
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave savedData = JsonUtility.FromJson<playerSave>(file);
        playerCoins = savedData.savedCoins;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
            playerSave savedData = JsonUtility.FromJson<playerSave>(file);
            playerCoins++;
            savedData.savedCoins = playerCoins;
            string toJson = JsonUtility.ToJson(savedData);
            JsonUtility.FromJsonOverwrite(toJson, savedData);
            string toFile = JsonUtility.ToJson(savedData);
            File.WriteAllText(Application.dataPath + "playerSaveData.json",toFile);
            Destroy(gameObject);
            
        }
    }
}
