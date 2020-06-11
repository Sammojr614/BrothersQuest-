﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    public Button quitButton;
    void Start()
    {
        quitButton.onClick.AddListener(quitOnClick);
    }

    void quitOnClick()
    {
        Application.Quit();
    }
}
