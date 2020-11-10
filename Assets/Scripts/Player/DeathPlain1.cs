using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Audio;

public class DeathPlain1 : MonoBehaviour
{
    public GameObject plainOfDeath;
    public List<Transform> Bros = new List<Transform>();
    public Transform playerSpawn;
    public playerSave plrSave = new playerSave();
    public AudioSource playClip;
    public AudioClip Hit;
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrSave = JsonUtility.FromJson<playerSave>(file);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //Green Bro
            if(BroSwitch.Bro == 1)
            {
                playClip.clip = Hit;
                playClip.Play();
                plrSave.savedHealth--;
                plrSave.savedCoins = plrSave.savedCoins - 5;
                Bros[0].position = playerSpawn.position;
                string toJson = JsonUtility.ToJson(plrSave);
                JsonUtility.FromJsonOverwrite(toJson, plrSave);
                string toFile = JsonUtility.ToJson(plrSave);
                File.WriteAllText(Application.dataPath + "playerSaveData.json",toFile);
               
                
            }else if(BroSwitch.Bro == 2)
            {
                playClip.clip = Hit;
                playClip.Play();
                plrSave.savedHealth--;
                plrSave.savedCoins = plrSave.savedCoins - 5;
                Bros[1].position = playerSpawn.position;
                string toJson = JsonUtility.ToJson(plrSave);
                JsonUtility.FromJsonOverwrite(toJson, plrSave);
                string toFile = JsonUtility.ToJson(plrSave);
                File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
            }else if(BroSwitch.Bro == 3)
            {
                playClip.clip = Hit;
                playClip.Play();
                plrSave.savedHealth--;
                plrSave.savedCoins = plrSave.savedCoins - 5;
                Bros[2].position = playerSpawn.position;
                string toJson = JsonUtility.ToJson(plrSave);
                JsonUtility.FromJsonOverwrite(toJson, plrSave);
                string toFile = JsonUtility.ToJson(plrSave);
                File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
            }
        }
    }
}
