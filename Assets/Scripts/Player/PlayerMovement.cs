using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static float moveSpeed;
    public static float jumpHeight;
    public static bool isGrounded;
    private void Update()
    {
        Jump();   
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }

    void Jump()
    {
        if (Input.GetButtonDown("PlayerJump"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, jumpHeight, 0f),ForceMode2D.Impulse);
        }
    }
}
