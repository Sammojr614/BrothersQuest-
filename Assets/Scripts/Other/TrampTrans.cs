using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampTrans : MonoBehaviour
{
    public List<GameObject> Bros = new List<GameObject>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetButton("Jump"))
        {
            print("Touching Player");
            if(BroSwitch.Bro == 1)
            {
                print("Jamie On Tramp");
                Bros[0].GetComponent<Rigidbody2D>().AddForce(Vector3.up*500);
            }
            if(BroSwitch.Bro == 2)
            {
                Bros[1].GetComponent<Rigidbody2D>().AddForce(Vector3.up * 500);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetButton("Jump"))
        {
            if(BroSwitch.Bro == 1)
            {
                Bros[0].GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600);
            }
            if (BroSwitch.Bro == 2)
            {
                Bros[1].GetComponent<Rigidbody2D>().AddForce(Vector3.up * 600);
            }
        }
    }
}
