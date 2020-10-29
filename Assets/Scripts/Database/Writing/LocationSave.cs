using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LocationSave : MonoBehaviour
{
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave savedData = JsonUtility.FromJson<playerSave>(file);
        savedData.savedLocation = SceneManager.GetActiveScene().name;
        string rewriteData = JsonUtility.ToJson(savedData);
        JsonUtility.FromJsonOverwrite(rewriteData, savedData);
        string writetoFile = JsonUtility.ToJson(savedData);
        File.WriteAllText(Application.dataPath + "playerSaveData.json", writetoFile);
    }
}
