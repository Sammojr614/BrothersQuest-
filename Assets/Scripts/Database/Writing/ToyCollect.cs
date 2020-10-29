using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ToyCollect : MonoBehaviour
{
    public static int toyAmount;
    playerSave plrDb = new playerSave();
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrDb = JsonUtility.FromJson<playerSave>(file);
        toyAmount = plrDb.collectedCharge;
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (BroSwitch.Bro == 1 && Input.GetMouseButtonDown(0))
        {
            if (toyAmount < 3)
            {
                toyAmount++;
                plrDb.collectedCharge = toyAmount;
                string toJson = JsonUtility.ToJson(plrDb);
                JsonUtility.FromJsonOverwrite(toJson, plrDb);
                string toFile = JsonUtility.ToJson(plrDb);
                File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
                Destroy(gameObject);
            }
            else
            {
                toyAmount = 3;
                Destroy(gameObject);
            }


        }
    }
}
