using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(ToyCollect.toyAmount > 0)
        {
            if (Input.GetMouseButtonDown(0) && BroSwitch.Bro ==2 || BroSwitch.Bro == 3)
            {
                
            }
        }
    }
}
