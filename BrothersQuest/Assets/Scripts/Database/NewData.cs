using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class NewData : MonoBehaviour
{
    public Button newData;
    DbManager dataMgr = DbManager.Instance;
    void Start()
    {
        if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            newData.gameObject.SetActive(false);
        }
        else
        {
            newData.gameObject.SetActive(true);
        }
        newData.onClick.AddListener(createOnClick);
    }

    void createOnClick()
    {
        if(!File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            dataMgr.dbHealth = 6;
            dataMgr.dbLives = 4;
            dataMgr.dbCurrency = 0;
            string tojson = JsonUtility.ToJson(dataMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);
            SceneManager.LoadScene("Testing");
        }
    }
}
