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
        if (Input.GetButtonDown("Horizontal") && GroundCheck.isGrounded == true)
        {
            playerAnimator.SetFloat("movement", 1);
        }else if (Input.GetButtonUp("Horizontal") && GroundCheck.isGrounded == true)
        {
            playerAnimator.SetFloat("movement", 0);
        }
        if(Input.GetButton("Jump") && GroundCheck.isGrounded != true)
        {
            playerAnimator.SetFloat("movement", 2);
        }
        if (Input.GetButtonUp("Jump") && GroundCheck.isGrounded == false)
        {
            playerAnimator.SetFloat("movement", 2);
        }
        
    }
}
