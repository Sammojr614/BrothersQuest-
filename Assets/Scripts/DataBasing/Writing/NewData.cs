using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class NewData : MonoBehaviour
{
    public Button CreateButton;
    public GameObject TutDialog;
    DbManager dataMgr = DbManager.Instance;
    void Start()
    {
        TutDialog.SetActive(false);
        if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            CreateButton.enabled = false;
        }else if(!File.Exists(Application.dataPath + "PlayerSaveData.json")) {
            CreateButton.enabled = true;
        }
        CreateButton.onClick.AddListener(CreateOnClick);

    }
    void CreateOnClick()
    {
       if(playerTut.playerHasPlayed == false)
        {
            dataMgr.dbLocation = "Tut1";
        }else if(playerTut.playerHasPlayed == true)
        {
            dataMgr.dbLocation = "Hub";
        }
        dataMgr.dbHealth = 6;
        dataMgr.dbLives = 4;
        dataMgr.dbCoins = 0;
        string tojson = JsonUtility.ToJson(dataMgr);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);
        TutDialog.SetActive(true);
    }

  
}
