using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAnimator : MonoBehaviour
{
    public Animator BrosAnimate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GroundCheck.isGrounded == true) {
            BrosAnimate.SetFloat("movement", 0f);
        }
       
        if (Input.GetButton("Horizontal") && GroundCheck.isGrounded == true)
        {
            BrosAnimate.SetFloat("movement", 1f);
        }
        if (Input.GetButtonDown("Jump"))
        {
            BrosAnimate.SetFloat("movement", 2f);
        }
    }
}
