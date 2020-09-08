using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampWEEE : MonoBehaviour
{
    public GameObject Player;
    public int FlingHeight;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, FlingHeight, 0f), ForceMode2D.Impulse);
        }
    }
}
