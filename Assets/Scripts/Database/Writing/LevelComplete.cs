using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public LevelIdex lvlIndex = new LevelIdex();
    public GameObject complete;
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "levelIndex.json");
        lvlIndex = JsonUtility.FromJson<LevelIdex>(file);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(SceneManager.GetActiveScene().name == "Lvl1")
        {
            if (collision.CompareTag("Player"))
            {
                lvlIndex.Lvl1Complete = true;
                string toJson = JsonUtility.ToJson(lvlIndex);
                JsonUtility.FromJsonOverwrite(toJson, lvlIndex);
                string toFile = JsonUtility.ToJson(lvlIndex);
                File.WriteAllText(Application.dataPath + "levelIndex.json",toFile);
                SceneManager.LoadScene("Hub");
            }
        }else if (SceneManager.GetActiveScene().name == "Lvl2")
        {
            if (collision.CompareTag("Player"))
            {
                lvlIndex.Lvl2Complete = true;
                string toJson = JsonUtility.ToJson(lvlIndex);
                JsonUtility.FromJsonOverwrite(toJson, lvlIndex);
                string toFile = JsonUtility.ToJson(lvlIndex);
                File.WriteAllText(Application.dataPath + "levelIndex.json", toFile);
                SceneManager.LoadScene("Hub");
            }else if(SceneManager.GetActiveScene().name == "Lvl3")
            {
                if (collision.CompareTag("Player"))
                {
                    lvlIndex.Lvl3Complete = true;
                    string toJson = JsonUtility.ToJson(lvlIndex);
                    JsonUtility.FromJsonOverwrite(toJson, lvlIndex);
                    string toFile = JsonUtility.ToJson(lvlIndex);
                    File.WriteAllText(Application.dataPath + "levelIndex.json", toFile);
                }
            }
        }
    }
}
