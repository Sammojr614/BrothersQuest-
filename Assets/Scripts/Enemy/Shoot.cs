using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public SpriteRenderer LegoHead;
    public GameObject Stud;
    public Sprite LegoHeadIdle;
    public Sprite LegoHeadShoot;

    //Max distance the enemy can fire
    public float xMin;
    public float xMax;

    //Direction the Stud is moving (by default this is left)
    private Vector3 MovingDirection = Vector3.left;

    //Speed the Stud is moving
    private float moveSpeed = 5f;

    private void Start()
    {
        Stud.SetActive(false);
        Stud.transform.position = LegoHead.transform.position;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //When the player steps within the trigger, the Stud will fire
        if (collision.CompareTag("Player"))
        {

            LegoHead.sprite = LegoHeadShoot;
            Stud.SetActive(true);

            //Prevents the Stud from going out of bounds
            if (Stud.transform.position.x >= xMin)
            {
                Stud.transform.Translate(MovingDirection * Time.smoothDeltaTime * moveSpeed);
            }
            else
            {
                Stud.transform.position = LegoHead.transform.position;
            }


        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //When the player leaves the range, the legohead will stop shooting
        if (collision.CompareTag("Player"))
        {
            LegoHead.sprite = LegoHeadIdle;
            Stud.SetActive(false);
            Stud.transform.position = LegoHead.transform.position;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Stud.SetActive(false);
            Stud.transform.position = LegoHead.transform.position;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
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
