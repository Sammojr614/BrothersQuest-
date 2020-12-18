using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public static int moveSpeed = 5;
    public static int jumpHeight = 5;
    int NumJumps = 0;
    private void Update()
    {
        if(BroSwitch.currentBro == 1)
        {
            moveSpeed = 6;
            jumpHeight = 8;
        }else if(BroSwitch.currentBro == 2)
        {
            moveSpeed = 5;
            jumpHeight = 5;
        }else if(BroSwitch.currentBro == 3)
        {
            moveSpeed = 4;
            jumpHeight = 5;
        }
        jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    void jump()
    {
        if(Input.GetButtonDown("Jump"))
        {
            if(GroundCheck.isGrounded == true)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode2D.Impulse);
                NumJumps = 0;
            }
            if(BroSwitch.currentBro == 2 && NumJumps < 2)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode2D.Impulse);
                NumJumps++;
            }
        }
    }
}
