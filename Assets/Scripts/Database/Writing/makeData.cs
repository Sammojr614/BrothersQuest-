using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class makeData : MonoBehaviour
{
    playerSave plrSave = new playerSave();
    private void Start()
    {
        if(!File.Exists(Application.dataPath + "playerSaveData.json"))
        {
            plrSave.savedCoins = 0;
            plrSave.savedHealth = 6;
            plrSave.savedLives = 4;
            plrSave.savedLocation = "Hub";
            plrSave.savedBro = 1;
            string jsonString = JsonUtility.ToJson(plrSave);
            File.WriteAllText(Application.dataPath + "playerSaveData.json", jsonString);
        }
    }
}
