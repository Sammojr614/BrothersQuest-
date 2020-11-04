using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;
    public Button resumeButton;

    private void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
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
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        isPaused = true;
    }
    void resumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        isPaused = false;
    }
}
