using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public List<Sprite> heads = new List<Sprite>();
    public Image showBro;
    private void Update()
    {
        if(BroSwitch.currentBro == 1)
        {
            showBro.sprite = heads[0];
        }else if(BroSwitch.currentBro == 2)
        {
            showBro.sprite = heads[1];
        }else if(BroSwitch.currentBro == 3)
        {
            showBro.sprite = heads[2];
        }
    }
}
