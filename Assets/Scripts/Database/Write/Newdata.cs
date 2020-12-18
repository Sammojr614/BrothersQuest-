using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Newdata : MonoBehaviour
{
    private void Update()
    {
        if (!File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            playerData savedata = new playerData();
            savedata.health = 6;
            savedata.lives = 4;
            savedata.location = "Hub";
            savedata.coins = 0;
            savedata.saveBro = 1;
            string tojson = JsonUtility.ToJson(savedata);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);
        }
    }
}
