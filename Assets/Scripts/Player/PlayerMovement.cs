using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public static int moveSpeed = 5;
    public static int jumpHeight = 5;
    private void Update()
    {
        jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    void jump()
    {
        if(GroundCheck.isGrounded == true && Input.GetButtonDown("Jump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, jumpHeight, 0f), ForceMode2D.Impulse);
        }
    }
}
