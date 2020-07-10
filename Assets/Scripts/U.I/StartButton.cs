using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    //Start button
    public Button start;

    //Required for the button to work
    void Start()
    {
        start.onClick.AddListener(pressScene);
    }

    //Loads the save screen
    void pressScene()
    {
        SceneManager.LoadScene("Saves");
    }
}
