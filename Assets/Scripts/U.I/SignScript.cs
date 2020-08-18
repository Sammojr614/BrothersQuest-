using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignScript : MonoBehaviour
{
    public GameObject Sign;
    public Text ReadMe;
    // Start is called before the first frame update
    void Start()
    {
        ReadMe.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ReadMe.enabled = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ReadMe.enabled = false;
        }
    }
}
