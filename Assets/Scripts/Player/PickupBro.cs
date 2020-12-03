using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBro : MonoBehaviour
{
    public GameObject Lou;
    public Transform Loutrans;
    public Transform ElTrans;
    public GameObject Elliot;
    public static bool PickedUp;
    private void Update()
    {
       if(BroSwitch.Bro == 2 && Elliot.GetComponent<BoxCollider2D>().IsTouching(Lou.GetComponent<BoxCollider2D>()))
        {
            if (Input.GetKeyUp(KeyCode.S) && PickedUp == false)
            {
                PickedUp = true;
            }else if (Input.GetKeyUp(KeyCode.S) && PickedUp == true)
            {
                PickedUp = false;
            }
        }
       if(PickedUp == true)
        {
            Loutrans.position = ElTrans.position;
        }
        else
        {
            Loutrans.position = Loutrans.position;
        }
    }

}
