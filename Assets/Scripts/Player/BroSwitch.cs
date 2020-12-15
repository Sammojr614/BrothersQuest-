using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroSwitch : MonoBehaviour
{
    public static int currentBro = 1;
    public List<GameObject> Bros;
    private void Update()
    {
        print(currentBro);
        if(currentBro < 3 && Input.GetKeyDown(KeyCode.E))
        {
            currentBro++;
        }else if(currentBro >=1 && Input.GetKeyDown(KeyCode.Q) && currentBro > 0)
        {
            currentBro--;
        }
        if(currentBro == 0)
        {
            currentBro = 1;
        }
        switch (currentBro)
        {
            case 1:
                //Freezing Rotatin so they wont fall through the floor
                Bros[0].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                Bros[1].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                Bros[2].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                //Disabling Colliders
                Bros[0].gameObject.GetComponent<BoxCollider2D>().enabled = true;
                Bros[1].gameObject.GetComponent<BoxCollider2D>().enabled = false;
                Bros[2].gameObject.GetComponent<BoxCollider2D>().enabled = false;
                //So they Can't move
                Bros[0].gameObject.GetComponent<PlayerMovement>().enabled = true;
                Bros[1].gameObject.GetComponent<PlayerMovement>().enabled = false;
                Bros[2].gameObject.GetComponent<PlayerMovement>().enabled = false;
                //locking animations
                Bros[1].gameObject.GetComponent<Animator>().SetFloat("movement", 0);
                Bros[2].gameObject.GetComponent<Animator>().SetFloat("movement", 0);

                break;
            case 2:
                //freezing so they don't fall
                Bros[0].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                Bros[1].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                Bros[2].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                //so they can't move
                Bros[0].gameObject.GetComponent<PlayerMovement>().enabled = false;
                Bros[1].gameObject.GetComponent<PlayerMovement>().enabled = true;
                Bros[2].gameObject.GetComponent<PlayerMovement>().enabled = false;
                //Disabling Colliders
                Bros[0].gameObject.GetComponent<BoxCollider2D>().enabled = false;
                Bros[1].gameObject.GetComponent<BoxCollider2D>().enabled = true;
                Bros[2].gameObject.GetComponent<BoxCollider2D>().enabled = false;
                //locking animations
                Bros[0].gameObject.GetComponent<Animator>().SetFloat("movement", 0);
                Bros[2].gameObject.GetComponent<Animator>().SetFloat("movement", 0);
                break;
            case 3:
                //Freezing them so they don't fall
                Bros[0].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                Bros[1].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                Bros[2].gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
                //so they can't move
                Bros[0].gameObject.GetComponent<PlayerMovement>().enabled = false;
                Bros[1].gameObject.GetComponent<PlayerMovement>().enabled = false;
                Bros[2].gameObject.GetComponent<PlayerMovement>().enabled = true;
                //Disabling Colliders
                Bros[0].gameObject.GetComponent<BoxCollider2D>().enabled = false;
                Bros[1].gameObject.GetComponent<BoxCollider2D>().enabled = false;
                Bros[2].gameObject.GetComponent<BoxCollider2D>().enabled = true;
                //locking animations
                Bros[0].gameObject.GetComponent<Animator>().SetFloat("movement", 0);
                Bros[1].gameObject.GetComponent<Animator>().SetFloat("movement", 0);
                break;
        }
    }
}
