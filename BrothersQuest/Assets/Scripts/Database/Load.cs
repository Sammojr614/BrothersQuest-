using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    public Button LoadButton;
    private void Start()
    {
        if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            LoadButton.gameObject.SetActive(true);
        }
        else
        {
            LoadButton.gameObject.SetActive(false);
        }
        LoadButton.onClick.AddListener(LoadClick);
    }
    void LoadClick()
    {
        string fromPlayerSave = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager loadData = JsonUtility.FromJson<DbManager>(fromPlayerSave);
        Health.playerHealth = loadData.dbHealth;
        Health.playerLives = loadData.dbLives;
        Coins.PlayerCoins = loadData.dbCurrency;
        SceneManager.LoadScene("Testing");
    }
}
