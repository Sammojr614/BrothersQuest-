using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Audio;

public class CoinCollect : MonoBehaviour
{
    public static int playerCoins;
    public AudioSource playAudio;
    public AudioClip collectSound;
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
            playAudio.clip = collectSound;
            playAudio.Play();
            string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
            playerSave savedData = JsonUtility.FromJson<playerSave>(file);
            if(playerCoins < 0)
            {
                playerCoins = 0;
            }
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
