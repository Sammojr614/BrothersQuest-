using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("moveLeft"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetButtonDown("moveRight"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
