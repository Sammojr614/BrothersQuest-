using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator PlayerAnimator;
 

    // Update is called once per frame
    void Update()
    {
        PlayerAnimator.SetFloat("movement", 0);
        if (Input.GetButton("Horizontal"))
        {
            PlayerAnimator.SetFloat("movement", 1f);
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
            PlayerAnimator.SetFloat("movement", 2f);
        }
       
    }
}
