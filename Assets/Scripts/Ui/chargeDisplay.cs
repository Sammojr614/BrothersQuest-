using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chargeDisplay : MonoBehaviour
{
    public Sprite emptyCharge;
    public Sprite almostEmpty;
    public Sprite almostFull;
    public Sprite FullCharge;

    public SpriteRenderer Charge;

    // Update is called once per frame
    void Update()
    {
        if(ToyCollect.toyAmount == 0)
        {
            Charge.sprite = emptyCharge;
        }else if(ToyCollect.toyAmount == 1)
        {
            Charge.sprite = almostEmpty;
        }else if(ToyCollect.toyAmount == 2) {
            Charge.sprite = almostFull;

        }else if(ToyCollect.toyAmount == 3)
        {
            Charge.sprite = FullCharge;
        }
        

    }
}
