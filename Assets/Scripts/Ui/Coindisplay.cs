using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Coindisplay : MonoBehaviour
{
    public Text coinCounter;

    // Update is called once per frame
    void Update()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave savedData = JsonUtility.FromJson<playerSave>(file);
        coinCounter.text ="x: "+  savedData.savedCoins.ToString();
    }
}
