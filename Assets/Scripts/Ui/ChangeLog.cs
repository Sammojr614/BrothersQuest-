using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeLog : MonoBehaviour
{
    public GameObject ChangeLogOverlay;
    public Button closeOverlay;
    public Button openOverlay;
    private void Start()
    {
        ChangeLogOverlay.SetActive(false);
        closeOverlay.onClick.AddListener(closeClick);
        openOverlay.onClick.AddListener(openOverlayAct);
        
    }
    void openOverlayAct()
    {
        ChangeLogOverlay.SetActive(true);
    }
    void closeClick()
    {
        ChangeLogOverlay.SetActive(false);
    }

}
