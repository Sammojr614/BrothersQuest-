using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public static int moveSpeed;
    public static float JumpHeight;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        transform.position += movement * Time.deltaTime * moveSpeed;
    }
    void Jump()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, JumpHeight, 0f),ForceMode2D.Impulse);
    }
}
