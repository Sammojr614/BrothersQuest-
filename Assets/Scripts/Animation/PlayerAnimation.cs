using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator PlayerAnimator;
 

    // Update is called once per frame
    void Update()
    {
        if(GroundCheck.isGrounded != false && !Input.GetButtonDown("Horizontal"))
        {
            PlayerAnimator.SetFloat("movement", 0);
        }
       
        if (Input.GetButton("Horizontal") && GroundCheck.isGrounded == true)
        {
            PlayerAnimator.SetFloat("movement", 1f);
        }
        if (Input.GetButtonUp("Horizontal") && GroundCheck.isGrounded ==  true)
        {
            PlayerAnimator.SetFloat("movement", 0);
        }
        if (Input.GetButtonDown("moveLeft"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }else if (Input.GetButtonDown("moveRight"))
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetButton("Jump"))
        {
          if(GroundCheck.isGrounded != true)
            {
                PlayerAnimator.SetFloat("movement", 2f);
            }
        }
       
    }
}
