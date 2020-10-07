using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float moveSpeed;
    public static float jumpHeight;
    public static bool isGrounded;
    public int playerJumps;
    private void Update()
    {
        Jump();
        crouch();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
        if(GroundCheck.isGrounded == true)
        {
            playerJumps = 0;
        }
    }

    void Jump()
    {
        
        if (Input.GetButtonDown("PlayerJump") && GroundCheck.isGrounded == true)
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, jumpHeight, 0f),ForceMode2D.Impulse);
            playerJumps++;
        }
        if (Input.GetButtonDown("PlayerJump") && BroSwitch.Bro == 2)
        {
            if(playerJumps < 2 && GroundCheck.isGrounded == false)
            {
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode2D.Impulse);
                playerJumps++;
            }if(playerJumps < 2)
            {
                playerJumps = 2;
            }
        }
    }
    void crouch()
    {
        if (Input.GetButtonDown("Crouch") && GroundCheck.isGrounded == true)
        {
            moveSpeed = moveSpeed - 2;
        }
    }
}
