using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class CoinCounter : MonoBehaviour
{
    public Text CurrencyDisplay;
    public Text LivesDisplay;
    private void Update()
    {
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager Coinsssss = JsonUtility.FromJson<DbManager>(fromJson);
        CurrencyDisplay.text ="x " +  Coinsssss.dbCoins.ToString();
        LivesDisplay.text = "Lives: " + Coinsssss.dbLives.ToString();
        
    }
    
}
