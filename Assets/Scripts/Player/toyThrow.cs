using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class toyThrow : MonoBehaviour
{

    playerSave plrDb = new playerSave();
    public GameObject ObjThrown;
    public Transform ElTrans;
    public Transform LouTrans;

    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrDb = JsonUtility.FromJson<playerSave>(file);
        ObjThrown.SetActive(false);
        if(BroSwitch.Bro <= 2)
        {
            ObjThrown.transform.position = ElTrans.position;
        }else if(BroSwitch.Bro == 3)
        {
            ObjThrown.transform.position = LouTrans.position;
        }
    }
    void Update()
    {
        
        //When the Bro is 2 or 3 it makes the Stud Shoot
        if(BroSwitch.Bro == 2 || BroSwitch.Bro == 3)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(BroSwitch.Bro <= 2)
                {
                    ObjThrown.transform.position = ElTrans.position;
                    if (ToyCollect.toyAmount > 0)
                    {
                        //Subtracting from the Total amount of toys collected 
                        ToyCollect.toyAmount--;
                        ObjThrown.SetActive(true);
                        ObjThrown.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 200 + Vector3.up * 200);
                        //Updating the Database
                        plrDb.collectedCharge = ToyCollect.toyAmount;
                        string toJson = JsonUtility.ToJson(plrDb);
                        JsonUtility.FromJsonOverwrite(toJson, plrDb);
                        string toFile = JsonUtility.ToJson(plrDb);
                        File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
                        if (ObjThrown.transform.position.y <= -4.04)
                        {
                            ObjThrown.transform.position = ElTrans.position;
                            ObjThrown.SetActive(false);
                        }
                    }
                    else if(ToyCollect.toyAmount == 0)
                    {
                        ObjThrown.SetActive(false);
                    }
                 

                }
                else if(BroSwitch.Bro == 3)
                {
                    ObjThrown.transform.position = LouTrans.position;
                    if (ToyCollect.toyAmount > 0)
                    {
                        //Subtracting from the Total amount of toys collected 
                        ToyCollect.toyAmount = ToyCollect.toyAmount -1;
                        ObjThrown.SetActive(true);
                        ObjThrown.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 200 + Vector3.up * 200);
                        //Updating the Database
                        plrDb.collectedCharge = ToyCollect.toyAmount;
                        string toJson = JsonUtility.ToJson(plrDb);
                        JsonUtility.FromJsonOverwrite(toJson, plrDb);
                        string toFile = JsonUtility.ToJson(plrDb);
                        File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
                        if (ObjThrown.transform.position.y <= -4.04)
                        {
                            ObjThrown.transform.position = LouTrans.position;
                            ObjThrown.SetActive(false);
                        }
                    }else if(ToyCollect.toyAmount == 0)
                    {
                        ObjThrown.SetActive(false);
                    }
                   
                }
            }
            else if(Input.GetButton("Horizontal"))
            {
                if (BroSwitch.Bro <= 2)
                {
                    ObjThrown.transform.position = ElTrans.position;
                    ObjThrown.SetActive(false);
                }
                else if (BroSwitch.Bro == 3)
                {
                    ObjThrown.transform.position = LouTrans.position;
                    ObjThrown.SetActive(false);
                }
            }
        }
       
    }

}
