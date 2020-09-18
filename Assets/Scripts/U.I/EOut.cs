using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EOut : MonoBehaviour
{
    public Sprite EyesOpen;
    public Sprite EyesClosed;
    public SpriteRenderer ERenderer;
    private void Update()
    {
        if(BroSwitch.Bro == 2)
        {
            ERenderer.sprite = EyesOpen;
        }
        else
        {
            ERenderer.sprite = EyesClosed;
        }
    }
}
