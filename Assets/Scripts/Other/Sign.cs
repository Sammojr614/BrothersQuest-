using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sign : MonoBehaviour
{
    public GameObject signText;
    private void Start()
    {
        signText.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            signText.SetActive(true);
        }
        if (collision.CompareTag("PlayerE"))
        {
            signText.SetActive(true);
        }
        if (collision.CompareTag("PlayerL"))
        {
            signText.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            signText.SetActive(true);
        }
        if (collision.CompareTag("PlayerE"))
        {
            signText.SetActive(true);
        }
        if (collision.CompareTag("PlayerL"))
        {
            signText.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            signText.SetActive(false);
        }
        if (collision.CompareTag("PlayerE"))
        {
            signText.SetActive(false);
        }
        if (collision.CompareTag("PlayerL"))
        {
            signText.SetActive(false);
        }
    }
}
