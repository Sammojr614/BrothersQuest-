using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroSwitch : MonoBehaviour
{
    public static int Bro = 1;
    private void Update()
    {
        if (Input.GetButtonUp("BroSwitchUp"))
        {
            Bro++;
            if(Bro >= 3)
            {
                Bro = 3;
            }
        }
        if (Input.GetButtonUp("BroSwitchDown"))
        {
            Bro--;
            if(Bro < 1)
            {
                Bro = 1;
            }
        }
    }
}
