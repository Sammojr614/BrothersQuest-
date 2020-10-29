using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class toyThrow : MonoBehaviour
{

    playerSave plrDb = new playerSave();
    public GameObject ObjThrown;

    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrDb = JsonUtility.FromJson<playerSave>(file);
        ObjThrown.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //When the Bro is 2 or 3 it makes the Stud Shoot
        if(BroSwitch.Bro == 2 && Input.GetMouseButtonDown(0) || BroSwitch.Bro == 3 && Input.GetMouseButtonDown(0))
        {
            
            if(ToyCollect.toyAmount > 0)
            {
               //Subtracting from the Total amount of toys collected 
                ToyCollect.toyAmount--;
                for (var i = 0; i < 10; i++)
                {
                    ObjThrown.SetActive(true);
                    ObjThrown.transform.Translate(Vector3.right* Time.smoothDeltaTime* 10);
                }
                //Updating the Database
                plrDb.collectedCharge = ToyCollect.toyAmount;
                string toJson = JsonUtility.ToJson(plrDb);
                JsonUtility.FromJsonOverwrite(toJson, plrDb);
                string toFile = JsonUtility.ToJson(plrDb);
                File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
            }
        }
    }
}
