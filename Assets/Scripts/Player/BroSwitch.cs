using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BroSwitch : MonoBehaviour
{
    public static int Bro;
    public List<GameObject> Bros = new List<GameObject>();
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave savedData = JsonUtility.FromJson<playerSave>(file);
        Bro = savedData.savedBro;
    }
    private void Update()
    {
       
        if (Input.GetButtonDown("BroSwitch") && Bro < 3)
        {
            Bro++;
            string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
            playerSave savedData = JsonUtility.FromJson<playerSave>(file);
            savedData.savedBro = Bro;
            string toJson = JsonUtility.ToJson(savedData);
            JsonUtility.FromJsonOverwrite(toJson, savedData);
            string toFile = JsonUtility.ToJson(savedData);
            File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
        }else if(Input.GetButtonDown("BroSwitch") && Bro >= 3)
        {
            Bro = 1;
            string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
            playerSave savedData = JsonUtility.FromJson<playerSave>(file);
            savedData.savedBro = Bro;
            string toJson = JsonUtility.ToJson(savedData);
            JsonUtility.FromJsonOverwrite(toJson, savedData);
            string toFile = JsonUtility.ToJson(savedData);
            File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
        }
        
        if(Bro == 1)
        {
            Bros[0].SetActive(true);
            Bros[1].SetActive(false);
            Bros[2].SetActive(false);
        }else if(Bro == 2)
        {
            Bros[0].SetActive(false);
            Bros[1].SetActive(true);
            Bros[2].SetActive(false);
        }else if(Bro == 3)
        {
            Bros[0].SetActive(false);
            Bros[1].SetActive(false);
            Bros[2].SetActive(true);
        }

    }
}
