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
        ObjThrown.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
        ObjThrown.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            if(BroSwitch.Bro == 2)
            {
                ObjThrown.gameObject.transform.position = ElTrans.position;
                ObjThrown.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            }
            else if(BroSwitch.Bro == 3)
            {
                ObjThrown.gameObject.transform.position = LouTrans.position;
                ObjThrown.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            }
        }
    }
    
    void Update()
    {
        //When the Bro is 2 or 3 it makes the Stud Shoot
        if(BroSwitch.Bro == 2 && Input.GetMouseButtonDown(0) || BroSwitch.Bro == 3 && Input.GetMouseButtonDown(0))
        {
            
            if(ToyCollect.toyAmount > 0)
            {
                //Subtracting from the Total amount of toys collected 
                ToyCollect.toyAmount--;
                ObjThrown.gameObject.GetComponentInChildren<SpriteRenderer>().enabled = true;
                ObjThrown.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 500 + Vector3.up*200);
                //Updating the Database
                plrDb.collectedCharge = ToyCollect.toyAmount;
                string toJson = JsonUtility.ToJson(plrDb);
                JsonUtility.FromJsonOverwrite(toJson, plrDb);
                string toFile = JsonUtility.ToJson(plrDb);
                File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
            }else if(BroSwitch.Bro == 2 && !Input.GetMouseButton(0) || BroSwitch.Bro == 3 && !Input.GetMouseButton(0))
            {
                if(BroSwitch.Bro == 2)
                {
                    ObjThrown.transform.position = ElTrans.position;
                }else if(BroSwitch.Bro == 3)
                {
                    ObjThrown.transform.position = LouTrans.position;
                }
            }
            {

            }
        }
    }
    
}
