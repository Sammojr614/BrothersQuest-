using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    bool paused;
    void Start()
    {
        pausePanel.SetActive(false);
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel") && paused == false)
        {
            pauseGame();
        }else if(Input.GetButtonDown("Cancel") && paused == true)
        {
            resumeGame();
        }
    }
    void pauseGame()
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        Cursor.visible = true;
        paused = true;
    }
    void resumeGame()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        pausePanel.SetActive(false);
        paused = false;
    }
 }
