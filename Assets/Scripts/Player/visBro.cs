using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visBro : MonoBehaviour
{
    public List<GameObject> brothers = new List<GameObject>();
    private void Update()
    {
        if (BroSwitch.Bro == 1)
        {
            brothers[0].SetActive(true);
            brothers[1].SetActive(false);
            brothers[2].SetActive(false);
            PlayerMovement.moveSpeed = 10;
            PlayerMovement.jumpHeight = 9;
        } else if (BroSwitch.Bro == 2)
        {
            brothers[1].SetActive(true);
            brothers[0].SetActive(false);
            brothers[2].SetActive(false);
            PlayerMovement.moveSpeed = 5;
            PlayerMovement.jumpHeight = 8;

        } else if (BroSwitch.Bro == 3)
        {
            brothers[1].SetActive(false);
            brothers[0].SetActive(false);
            brothers[2].SetActive(true);
            PlayerMovement.moveSpeed = 2;
            PlayerMovement.jumpHeight = 4;
        }
    }

}
