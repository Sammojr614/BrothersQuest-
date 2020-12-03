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
       
        if (Input.GetKeyDown(KeyCode.E) && Bro < 3)
        {
            Bro++;
            string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
            playerSave savedData = JsonUtility.FromJson<playerSave>(file);
            savedData.savedBro = Bro;
            string toJson = JsonUtility.ToJson(savedData);
            JsonUtility.FromJsonOverwrite(toJson, savedData);
            string toFile = JsonUtility.ToJson(savedData);
            File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
        }else if(Input.GetKeyDown(KeyCode.E) && Bro >= 3)
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
        if(Input.GetKeyDown(KeyCode.Q) && Bro == 1)
        {
            Bro = 3;
            string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
            playerSave savedData = JsonUtility.FromJson<playerSave>(file);
            savedData.savedBro = Bro;
            string toJson = JsonUtility.ToJson(savedData);
            JsonUtility.FromJsonOverwrite(toJson, savedData);
            string toFile = JsonUtility.ToJson(savedData);
            File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
        }else if(Input.GetKeyDown(KeyCode.Q) && Bro <= 3)
        {
            Bro--;
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
            //J
            Bros[0].GetComponent<PlayerMovement>().enabled = true;
            Bros[0].GetComponent<BoxCollider2D>().isTrigger = false;
            Bros[0].GetComponent<Rigidbody2D>().IsAwake();
            //El
            Bros[1].GetComponent<PlayerMovement>().enabled = false;
            Bros[1].GetComponent<BoxCollider2D>().isTrigger = true;
            Bros[1].GetComponent<Rigidbody2D>().Sleep();
            Bros[1].GetComponent<Animator>().SetFloat("movement", 0f);
            //Lou
            Bros[2].GetComponent<PlayerMovement>().enabled = false;
            Bros[2].GetComponent<BoxCollider2D>().isTrigger = true;
            Bros[2].GetComponent<Rigidbody2D>().Sleep();
            Bros[2].GetComponent<Animator>().SetFloat("movement", 0f);
        }
        else if(Bro == 2)
        {
            //J
            Bros[0].GetComponent<PlayerMovement>().enabled = false;
            Bros[0].GetComponent<BoxCollider2D>().isTrigger = true;
            Bros[0].GetComponent<Rigidbody2D>().Sleep();
            Bros[0].GetComponent<Animator>().SetFloat("movement", 0f);
            //El
            Bros[1].GetComponent<PlayerMovement>().enabled = true;
            Bros[1].GetComponent<BoxCollider2D>().isTrigger = false;
            Bros[1].GetComponent<Rigidbody2D>().IsAwake();
            //Lou
            Bros[2].GetComponent<PlayerMovement>().enabled = false;
            Bros[2].GetComponent<BoxCollider2D>().isTrigger = true;
            Bros[2].GetComponent<Rigidbody2D>().Sleep();
            Bros[2].GetComponent<Animator>().SetFloat("movement", 0f);
        }
        else if(Bro == 3)
        {
            //J
            Bros[0].GetComponent<PlayerMovement>().enabled = false;
            Bros[0].GetComponent<BoxCollider2D>().isTrigger = true;
            Bros[0].GetComponent<Rigidbody2D>().Sleep();
            Bros[0].GetComponent<Animator>().SetFloat("movement", 0f);
            //El
            Bros[1].GetComponent<PlayerMovement>().enabled = false;
            Bros[1].GetComponent<BoxCollider2D>().isTrigger = true;
            Bros[1].GetComponent<Rigidbody2D>().Sleep();
            Bros[1].GetComponent<Animator>().SetFloat("movement", 0f);
            //Lou
            Bros[2].GetComponent<PlayerMovement>().enabled = true;
            Bros[2].GetComponent<BoxCollider2D>().isTrigger = false;
            Bros[2].GetComponent<Rigidbody2D>().IsAwake();
        }

    }
}
