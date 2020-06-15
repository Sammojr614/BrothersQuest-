using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public SpriteRenderer LegoHead;
    public GameObject Stud;
    public Sprite LegoHeadIdle;
    public Sprite LegoHeadShoot;
    Vector3 change = new Vector3(-3f, 0f, 0f);
    private void Start()
    {
        Stud.SetActive(false);
        Stud.transform.position = LegoHead.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Stud.transform.position += change;
            LegoHead.sprite = LegoHeadShoot;
            Stud.SetActive(true);
          

        }
        else
        {
            LegoHead.sprite = LegoHeadIdle;
            Stud.SetActive(false);
            Stud.transform.position = LegoHead.transform.position;

        }
    }
}
