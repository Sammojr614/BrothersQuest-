using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverButtons : MonoBehaviour
{
    public Button continueButton;
    public Button quitButton;
    playerSave plrSave = new playerSave();
    private void Start()
    {
        Cursor.visible = true;
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrSave = JsonUtility.FromJson<playerSave>(file);
        continueButton.onClick.AddListener(continueClick);
        quitButton.onClick.AddListener(quitClick);
    }

    void continueClick()
    {
        plrSave.savedHealth = 6;
        plrSave.savedLives = 4;
        SceneManager.LoadScene("Hub");
        string toJson = JsonUtility.ToJson(plrSave);
        JsonUtility.FromJsonOverwrite(toJson, plrSave);
        string toFile = JsonUtility.ToJson(plrSave);
        File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
        
    }
    void quitClick()
    {
        plrSave.savedHealth = 6;
        plrSave.savedLives = 4;
        plrSave.savedLocation = "Hub";
        string toJson = JsonUtility.ToJson(plrSave);
        JsonUtility.FromJsonOverwrite(toJson, plrSave);
        string toFile = JsonUtility.ToJson(plrSave);
        File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
        SceneManager.LoadScene("Title");
    }
}
