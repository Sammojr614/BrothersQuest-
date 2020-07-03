using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public string sceneName;
    public Button SceneButton;
    void Start()
    {
        SceneButton.onClick.AddListener(moveScene);
    }

   void moveScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
