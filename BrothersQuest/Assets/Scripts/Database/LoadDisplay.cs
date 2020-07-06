using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class LoadDisplay : MonoBehaviour
{
    public Text LivesDisplay;
    public Text CurrencyDisplay;
    public GameObject Cloud;
    public Text FileTitle;

    private void Update()
    {
       if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            Cloud.SetActive(true);
            LivesDisplay.gameObject.SetActive(true);
            CurrencyDisplay.gameObject.SetActive(true);
            FileTitle.gameObject.SetActive(true);
            string fromPlayerSave = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
            DbManager loadDb = JsonUtility.FromJson<DbManager>(fromPlayerSave);
            LivesDisplay.text = "Lives: " + loadDb.dbLives.ToString();
            CurrencyDisplay.text = ": " + loadDb.dbCurrency.ToString();
            
        }else if(!File.Exists(Application.dataPath+ "PlayerSaveData.json")) {
            Cloud.SetActive(false);
            LivesDisplay.gameObject.SetActive(false);
            CurrencyDisplay.gameObject.SetActive(false);
            FileTitle.gameObject.SetActive(false);
        }


    }
}
