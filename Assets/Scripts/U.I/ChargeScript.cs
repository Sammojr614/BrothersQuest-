using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeScript : MonoBehaviour
{
    public static int ChargesLeft = 4;
    public Sprite FullCharge;
    public Sprite AlmostFull;
    public Sprite AlmostEmpty;
    public Sprite Empty;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1) && ChargesLeft > 0)
        {
            ChargesLeft--;
        }
        if(ChargesLeft == 4)
        {
            
        }
    }
}
