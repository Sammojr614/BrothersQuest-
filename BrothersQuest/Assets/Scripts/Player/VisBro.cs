using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisBro : MonoBehaviour
{
    public List<GameObject> Bros = new List<GameObject>();
    private void Update()
    {
        if (Input.GetButtonDown("BroSwitchUp") || Input.GetButtonDown("BroSwitchDown") && BroSwitch.Bro == 2)
        {
            Bros[1].transform.position = Bros[0].transform.position;
        }
        if(Input.GetButtonDown("BroSwitchUp") || Input.GetButtonDown("BroSwitchDown") && BroSwitch.Bro == 3)
        {
            Bros[2].transform.position = Bros[1].transform.position;
        }
        if(Input.GetButtonDown("BroSwitchUp") || Input.GetButtonDown("BroSwitchDown") && BroSwitch.Bro == 1)
        {
            Bros[0].transform.position = Bros[2].transform.position;
        }
        if(BroSwitch.Bro == 3)
        {
            PlayerMovement.JumpHeight = 4f;
            PlayerMovement.moveSpeed = 3;
            Bros[2].SetActive(true);
            Bros[1].SetActive(false);
            Bros[0].SetActive(false);
        }
        if(BroSwitch.Bro == 2)
        {
            PlayerMovement.moveSpeed = 6;
            PlayerMovement.JumpHeight = 7f;
            Bros[2].SetActive(false);
            Bros[1].SetActive(true);
            Bros[0].SetActive(false);
        }
        if(BroSwitch.Bro == 1)
        {
            PlayerMovement.moveSpeed = 10;
            PlayerMovement.JumpHeight = 6;
            Bros[2].SetActive(false);
            Bros[1].SetActive(false);
            Bros[0].SetActive(true);
        }
    }
}
