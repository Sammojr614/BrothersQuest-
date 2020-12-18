using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Button ResumeButton;
    public Button QuitButton;
    playerData plrdata = new playerData();
    // Start is called before the first frame update
    void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        plrdata = JsonUtility.FromJson<playerData>(file);
        ResumeButton.onClick.AddListener(ResumeClick);
        QuitButton.onClick.AddListener(QuitClick);
    }
    void ResumeClick()
    {
        plrdata.health = 6;
        plrdata.lives = 4;
        string tojson = JsonUtility.ToJson(plrdata);
        JsonUtility.FromJsonOverwrite(tojson, plrdata);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json",tojson);
        SceneManager.LoadScene("Hub");
    }
   void QuitClick()
    {
        plrdata.health = 6;
        plrdata.lives = 4;
        string toJson = JsonUtility.ToJson(plrdata);
        JsonUtility.FromJsonOverwrite(toJson, plrdata);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json", toJson);
        SceneManager.LoadScene("Title");

    }
}
