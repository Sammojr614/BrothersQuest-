﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(quitGame);
    }
    void quitGame()
    {
        Application.Quit();
    }

    
   
}