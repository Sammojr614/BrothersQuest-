using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchGround : MonoBehaviour
{
    public List<GameObject> Bros = new List<GameObject>();
    private void Update()
    {
        if(BroSwitch.Bro == 1)
        {
            Bros[0].gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            Bros[1].gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            Bros[2].gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }else if(BroSwitch.Bro == 2)
        {
            if(PickupBro.PickedUp == true)
            {
                Bros[0].gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                Bros[1].gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                Bros[2].gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
            }
            else
            {
                Bros[0].gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
                Bros[1].gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
                Bros[2].gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            }
        }
        else if(BroSwitch.Bro == 3)
        {
            Bros[0].gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            Bros[1].gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
            Bros[2].gameObject.GetComponent<BoxCollider2D>().isTrigger = true;
        }
    }
}
