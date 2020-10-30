using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampTrans : MonoBehaviour
{
    public List<Transform> Bros = new List<Transform>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(BroSwitch.Bro == 1)
            {
                
            }
        }
    }
}
