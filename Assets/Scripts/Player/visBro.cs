using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visBro : MonoBehaviour
{
    public List<GameObject> brothers = new List<GameObject>();
    private void Update()
    {
        //First Bro
        if (BroSwitch.Bro == 1)
        {
            brothers[0].SetActive(true);
            brothers[1].SetActive(false);
            brothers[2].SetActive(false);
            PlayerMovement.moveSpeed = 10;
            PlayerMovement.jumpHeight = 9;
            //Second Bro
        } else if (BroSwitch.Bro == 2)
        {
            brothers[1].SetActive(true);
            brothers[0].SetActive(false);
            brothers[2].SetActive(false);
            PlayerMovement.moveSpeed = 5;
            PlayerMovement.jumpHeight = 8;
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
