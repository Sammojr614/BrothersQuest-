using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    playerSave plrSave = new playerSave();
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrSave = JsonUtility.FromJson<playerSave>(file);
    }
    private void Update()
    {
        if(plrSave.savedLives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
