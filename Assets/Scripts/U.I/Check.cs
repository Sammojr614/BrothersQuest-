using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Check : MonoBehaviour
{
    public Button LoadButton;
    public Button newDataButton;
    public GameObject LoadDisplay;

    // Start is called before the first frame update
    void Start()
    {
        if(File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            newDataButton.gameObject.SetActive(false);
            LoadButton.gameObject.SetActive(true);
            LoadDisplay.SetActive(true);
        }else if(!File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            newDataButton.gameObject.SetActive(true);
            LoadButton.gameObject.SetActive(false);
            LoadDisplay.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (File.Exists(Application.dataPath + "PlayerSaveData.json"))
        {
            newDataButton.gameObject.SetActive(false);
            LoadButton.gameObject.SetActive(true);
        }
    }
}
