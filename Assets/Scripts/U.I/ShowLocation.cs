using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class ShowLocation : MonoBehaviour
{
    public Text locationDisplay;
    void Start()
    {
        string textString = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager fromJson = JsonUtility.FromJson<DbManager>(textString);
        locationDisplay.text = fromJson.dbLocation;
    }

   
   
}
