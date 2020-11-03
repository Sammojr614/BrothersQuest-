using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimate : MonoBehaviour
{
    public Animator playerAnimator;
    private void Update()
    {
        
        if (Input.GetButtonDown("moveLeft"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetButtonDown("moveRight"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
       if(GroundCheck.isGrounded == true)
        {
            playerAnimator.SetFloat("movement", 0f);
            if (Input.GetButton("Horizontal"))
            {
                playerAnimator.SetFloat("movement", 1f);
            }
            if (Input.GetButton("Jump"))
            {
                playerAnimator.SetFloat("movement", 2f);
            }

        }
        else if(GroundCheck.isGrounded == false)
        {
            playerAnimator.SetFloat("movement", 2f);
        }
        
    }
}
