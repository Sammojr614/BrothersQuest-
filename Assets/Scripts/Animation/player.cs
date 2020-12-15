using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetButtonDown("moveLeft"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (Input.GetButtonDown("moveRight"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetButtonDown("Horizontal") && GroundCheck.isGrounded == true)
        {
            gameObject.GetComponent<Animator>().SetFloat("movement", 1);
        }else if (Input.GetButtonUp("Horizontal")) {
            gameObject.GetComponent<Animator>().SetFloat("movement", 0);
        }

        if(Input.GetButtonDown("Jump") || GroundCheck.isGrounded == false)
        {
            gameObject.GetComponent<Animator>().SetFloat("movement", 2);
        }
    }
}
