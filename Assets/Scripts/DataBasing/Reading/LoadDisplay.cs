using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadDisplay : MonoBehaviour
{
    public Text LivesDisplay;
    public Text MoneyDisplay;
    public Text LocationDisplay;
    public Text healthDisplay;

   
    void Update()
    {
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager forDisplays = JsonUtility.FromJson<DbManager>(fromJson);
        LivesDisplay.text ="Lives: "+  forDisplays.dbHealth.ToString();
        MoneyDisplay.text = "x: " +  forDisplays.dbCoins.ToString();
        LocationDisplay.text ="Where: " + forDisplays.dbLocation;
        if(forDisplays.dbHealth == 6)
        {
            healthDisplay.text = "Health: Full";
        }else if(forDisplays.dbHealth == 3)
        {
            healthDisplay.text = "Health: Half";
        }else if(forDisplays.dbHealth == 1)
        {
            healthDisplay.text = "Health: DANGER!";
        }

    }
}
