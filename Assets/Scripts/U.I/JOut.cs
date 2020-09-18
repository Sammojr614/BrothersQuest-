using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JOut : MonoBehaviour
{
    public Sprite eyesOpen;
    public Sprite EyesClosed;
    public SpriteRenderer JSpriteRenderer;
    private void Update()
    {
        if(BroSwitch.Bro == 1)
        {
            JSpriteRenderer.sprite = eyesOpen;
        }
        else
        {
            JSpriteRenderer.sprite = EyesClosed;
        }
    }
}
