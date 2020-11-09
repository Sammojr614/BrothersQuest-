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
    playerSave readData = new playerSave();
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        readData = JsonUtility.FromJson<playerSave>(file);
    }
    // Update is called once per frame
    void Update()
    { 
        lives.text ="Lives: " +  readData.savedLives.ToString();
        Coins.text ="x: " +  readData.savedCoins.ToString();
        playerlocation.text = readData.savedLocation;
        switch (readData.savedHealth)
        {
            case 6:
                health.text = "Health: Full";
                break;
            case 5:
                health.text = "Health: Pretty Much Full";
                break;
            case 4:
                health.text = " Health: Almost Half";
                break;
            case 3:
                health.text = "Health: Half";
                break;
            case 2:
                health.text = "Health: Almost Gone";
                break;
            case 1:
                health.text = "Health: Half a heart!";
                break;
        }
    }
}
