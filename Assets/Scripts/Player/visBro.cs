using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visBro : MonoBehaviour
{
    public List<GameObject> brothers = new List<GameObject>();
    private void Update()
    {
        //all of these are for putting the bros where the prevously used bro was 
        if (Input.GetButton("BroSwitch") || Input.GetButton("BroSwitchNeg") && BroSwitch.Bro == 2)
        {
            brothers[1].transform.position = brothers[0].transform.position;
        }
        if (Input.GetButton("BroSwitch") || Input.GetButton("BroSwitchNeg") && BroSwitch.Bro == 3)
        {
            brothers[2].transform.position = brothers[1].transform.position;
        }
        if (Input.GetButton("BroSwitch") || Input.GetButton("BroSwitchNeg") && BroSwitch.Bro == 1)
        {
            brothers[0].transform.position = brothers[2].transform.position;
        }
        //First Bro
        if (BroSwitch.Bro == 1)
        {
            brothers[0].SetActive(true);
            brothers[1].SetActive(false);
            brothers[2].SetActive(false);
            PlayerMovement.moveSpeed = 8;
            PlayerMovement.jumpHeight = 6;
            //Second Bro
        } else if (BroSwitch.Bro == 2)
        {
            brothers[1].SetActive(true);
            brothers[0].SetActive(false);
            brothers[2].SetActive(false);
            PlayerMovement.moveSpeed = 5;
            PlayerMovement.jumpHeight = 5;
            //Putting the Bro Into The Pos of the first
            /*brothers[1].transform.position = brothers[0].transform.position;*/

            //Third Bro
        } else if (BroSwitch.Bro == 3)
        {
            brothers[1].SetActive(false);
            brothers[0].SetActive(false);
            brothers[2].SetActive(true);
            PlayerMovement.moveSpeed = 2;
            PlayerMovement.jumpHeight = 4;
            //Putting the 3 bro where the 1st bro was 
            /*brothers[2].transform.position = brothers[1].transform.position;*/
        }
    }

}
