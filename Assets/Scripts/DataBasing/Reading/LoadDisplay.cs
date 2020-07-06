using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadDisplay : MonoBehaviour
{
    public Text LivesDisplay;
    public Text MoneyDisplay;

   
    void Update()
    {
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager forDisplays = JsonUtility.FromJson<DbManager>(fromJson);
        LivesDisplay.text = forDisplays.dbHealth.ToString();
    }
}
