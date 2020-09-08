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
        //Something to say something besides Tut# in The Display
        if(forDisplays.dbLocation == "Tut1"|| forDisplays.dbLocation == "Tut2"|| forDisplays.dbLocation == "Tut3"|| forDisplays.dbLocation == "Tut4")
        {
            LocationDisplay.text = "Where: The Tutorial";
        }
        else
        {
            LocationDisplay.text ="Where: " +  forDisplays.dbLocation;
        }
        //For the Health, i had to do it differently 
        if (forDisplays.dbHealth == 6)
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
