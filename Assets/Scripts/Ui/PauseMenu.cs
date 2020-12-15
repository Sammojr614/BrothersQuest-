using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    public static bool isPaused;
    public Button resumeButton;
    private void Start()
    {
        menu.SetActive(false);
        resumeButton.onClick.AddListener(resumeGame);
    }
    private void Update()
    {
        if (Input.GetButtonDown("Cancel") && isPaused == false)
        {
            pauseGame();
        }else if(Input.GetButtonDown("Cancel") && isPaused == true)
        {
            resumeGame();
        }
    }
    void pauseGame()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        menu.SetActive(true);
        isPaused = true;

    }
    void resumeGame()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        menu.SetActive(false);
        isPaused = false;
    }
}
