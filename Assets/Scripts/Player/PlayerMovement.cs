using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    int moveSpeed;
    int jumpheight;

    // Update is called once per frame
    void Update()
    {
        if(BroSwitch.Bro == 1)
        {
            moveSpeed = 8;
            jumpheight = 9;
        }else if(BroSwitch.Bro == 2)
        {
            moveSpeed = 5;
            jumpheight = 5;
        }else if(BroSwitch.Bro == 3)
        {
            moveSpeed = 3;
            jumpheight = 2;
        }
        jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    void jump()
    {
        if (Input.GetButtonDown("Jump") && GroundCheck.isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, jumpheight, 0f), ForceMode2D.Impulse);
        }
    }
}
