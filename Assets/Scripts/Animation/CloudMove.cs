using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMove : MonoBehaviour
{
    float cloudY;
    private void Start()
    {
        
    }
    private void Update()
    {
        if(gameObject.transform.position.x <= -7.79)
        {
            gameObject.transform.position = new Vector3(60.16f, gameObject.transform.position.y, 0);
        }
        else
        {
            if(gameObject.name.Contains("BeegCloud"))
            {
                gameObject.transform.Translate(new Vector3(-.03f, 0f, 0f));
            }else if(gameObject.name.Contains("MedCloud"))
            {
                gameObject.transform.Translate(new Vector3(-.04f, 0f, 0f));
            }else if (gameObject.name.Contains("SmolCloud"))
            {
                gameObject.transform.Translate(new Vector3(-.05f, 0f, 0f));
            }
        }
    }
}
