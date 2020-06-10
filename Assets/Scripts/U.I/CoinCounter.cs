using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CoinCounter : MonoBehaviour
{
    public Text CurrencyDisplay;
    private void Update()
    {
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager Coinsssss = JsonUtility.FromJson<DbManager>(fromJson);
        CurrencyDisplay.text ="Monies: " +  Coinsssss.dbCoins.ToString();
    }
}
