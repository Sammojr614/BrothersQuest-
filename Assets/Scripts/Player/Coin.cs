using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject Collect;
    public static int PlayerCoins;
    void Start()
    {
        Collect.SetActive(true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Collect.SetActive(false);
            PlayerCoins++;
        }
    }
}
