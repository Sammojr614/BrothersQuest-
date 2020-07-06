using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paused : MonoBehaviour
{
    public GameObject PauseMenu;
    public Button resumeButton;
    private void Start()
    {
        PauseMenu.SetActive(false);
        resumeButton.onClick.AddListener(resumeGame);
    }
    private void Update()
    {
        if (Input.GetButton("Cancel"))
        {
            pauseGame();
        }
    }
    void pauseGame()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        PauseMenu.SetActive(true);
    }
    void resumeGame()
    {
        Time.timeScale = 1;
        Cursor.visible = false;
        PauseMenu.SetActive(false);
    }
}

