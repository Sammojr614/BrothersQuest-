using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public LevelIdex lvlIndex = new LevelIdex();
    public GameObject complete;
    public GameObject J;
    public GameObject El;
    public GameObject Lou;
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "levelIndex.json");
        lvlIndex = JsonUtility.FromJson<LevelIdex>(file);
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Lvl1")
        {
            if (gameObject.GetComponent<BoxCollider2D>().IsTouching(J.GetComponent<BoxCollider2D>()))
            {
                if (gameObject.GetComponent<BoxCollider2D>().IsTouching(El.GetComponent<BoxCollider2D>()))
                {
                    if (gameObject.GetComponent<BoxCollider2D>().IsTouching(Lou.GetComponent<BoxCollider2D>()))
                    {
                        lvlIndex.Lvl1Complete = true;
                        string tojson = JsonUtility.ToJson(lvlIndex);
                        JsonUtility.FromJsonOverwrite(tojson, lvlIndex);
                    }
                }
            }
        }
      
    }
}
