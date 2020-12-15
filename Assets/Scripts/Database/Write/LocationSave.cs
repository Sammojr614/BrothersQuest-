using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LocationSave : MonoBehaviour
{
    playerData plrData = new playerData();
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        plrData = JsonUtility.FromJson<playerData>(file);
        plrData.location = SceneManager.GetActiveScene().name;
        string tojson = JsonUtility.ToJson(plrData);
        JsonUtility.FromJsonOverwrite(tojson, plrData);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);
    }
}
