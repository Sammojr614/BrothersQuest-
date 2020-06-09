using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroSwitch : MonoBehaviour
{
    public static int Bro = 1;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("BroSwitch") && Bro < 3)
        {
            Bro++;
            if(Bro > 3)
            {
                Bro = 3;
            }
        }
        if (Input.GetButtonDown("BroSwitchNeg"))
        {
            Bro--;
            if(Bro < 1)
            {
                Bro = 1;
            }
        }
    }
}
