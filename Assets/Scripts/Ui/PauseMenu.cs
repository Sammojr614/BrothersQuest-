using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public static bool isPaused;

    private void Start()
    {
        pauseMenu.SetActive(false);
        isPaused = false;
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
