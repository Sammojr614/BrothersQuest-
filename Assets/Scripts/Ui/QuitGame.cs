using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quitgame : MonoBehaviour
{ 
    public Button quitButton;
    private void Start()
    {
        quitButton.onClick.AddListener(Application.Quit);
    }
    

}
