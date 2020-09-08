using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampWEEE : MonoBehaviour
{
    public List<GameObject> Brothers;
    int FlingHeight = 20;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(BroSwitch.Bro == 1)
            {
                Brothers[0].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, FlingHeight, 0f), ForceMode2D.Impulse);
            }
            if(BroSwitch.Bro == 2)
            {
                Brothers[1].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, FlingHeight, 0f), ForceMode2D.Impulse);
            }
            if(BroSwitch.Bro == 3)
            {
                Brothers[2].gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector3(0f, FlingHeight, 0f), ForceMode2D.Impulse);
            }
        }
    }
}
