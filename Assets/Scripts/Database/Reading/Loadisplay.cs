using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;


public class Loadisplay : MonoBehaviour
{
    public Text lives;
    public Text health;
    public Text Coins;
    public Text playerlocation;
    // Update is called once per frame
    void Update()
    {
        string loadedData = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave readData = JsonUtility.FromJson<playerSave>(loadedData);
        lives.text ="Lives: " +  readData.savedLives.ToString();
        Coins.text ="x: " +  readData.savedCoins.ToString();
        playerlocation.text = readData.savedLocation;
        if(readData.savedHealth == 6)
        {
            health.text = "Health: Full";
        }else if(readData.savedHealth == 3)
        {
            health.text = "Health: Half";
        }else if(readData.savedHealth == 1)
        {
            health.text = "Health: Almost Gone";
        }
    }
}
