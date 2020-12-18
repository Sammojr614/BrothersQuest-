using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Twt : MonoBehaviour
{
    LvlIndex lvlidx = new LvlIndex();
    bool Jtri;
    bool elTri;
    bool Ltri;
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "LevelIndex.json");
        lvlidx = JsonUtility.FromJson<LvlIndex>(file);
        Jtri = false;
        Ltri = false;
        elTri = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            Jtri = true;
        }
        if (collision.CompareTag("PlayerE"))
        {
            elTri = true;
        }
        if (collision.CompareTag("PlayerL"))
        {
            Ltri = true;
        }
    }
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "TutEnd")
        {
            if(Jtri == true && Ltri == true && elTri == true)
            {
                lvlidx.TutorialDone = true;
                string toJson = JsonUtility.ToJson(lvlidx);
                JsonUtility.FromJsonOverwrite(toJson, lvlidx);
                File.WriteAllText(Application.dataPath + "LevelIndex.json", toJson);
                SceneManager.LoadScene("Hub");
            }
        }
    }
}