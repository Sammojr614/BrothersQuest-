using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;

public class MoveSceneButton : MonoBehaviour
{
    public Button SceneButton;
    public string sceneName;
   
    void Start()
    {
        if (File.Exists(Application.dataPath + "PlayerSaveData.json")) {
            SceneButton.enabled = true;
        } else if (!File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            SceneButton.enabled = false;
        }
        SceneButton.onClick.AddListener(pressScene);
    }

    void pressScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
