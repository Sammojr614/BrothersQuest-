using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveSceneButton : MonoBehaviour
{
     Button sceneButton;
    public string sceneName;
    void Start()
    {
        sceneButton = gameObject.GetComponent<Button>();
        sceneButton.onClick.AddListener(sceneClick);
    }

    void sceneClick()
    {
        SceneManager.LoadScene(sceneName);
    }
}
