using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
{
    private void Update()
    {
        string fromDb = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager loadLives = JsonUtility.FromJson<DbManager>(fromDb);
        if(loadLives.dbLives <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
