using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class moveScene : MonoBehaviour
{
    public string sceneName;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(changeScene);
    }

   void changeScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
