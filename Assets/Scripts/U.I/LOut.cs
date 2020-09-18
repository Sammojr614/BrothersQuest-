using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOut : MonoBehaviour
{
    public Sprite eyesOpen;
    public Sprite eyesClosed;
    public SpriteRenderer LRenderer;

    private void Update()
    {
        if (BroSwitch.Bro == 3)
        {
            LRenderer.sprite = eyesOpen;
        }
        else
        {
            LRenderer.sprite = eyesClosed;
        }
    }
}
