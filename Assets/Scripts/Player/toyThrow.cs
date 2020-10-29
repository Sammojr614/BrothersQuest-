using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class toyThrow : MonoBehaviour
{

    playerSave plrDb = new playerSave();

    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrDb = JsonUtility.FromJson<playerSave>(file);
    }
    // Update is called once per frame
    void Update()
    {
        if(BroSwitch.Bro == 2 && Input.GetMouseButtonDown(0) || BroSwitch.Bro == 3 && Input.GetMouseButtonDown(0))
        {
            if(ToyCollect.toyAmount > 0)
            {
                ToyCollect.toyAmount--;
                plrDb.collectedCharge = ToyCollect.toyAmount;
                string toJson = JsonUtility.ToJson(plrDb);
                JsonUtility.FromJsonOverwrite(toJson, plrDb);
                string toFile = JsonUtility.ToJson(plrDb);
                File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
            }
        }
    }
}
