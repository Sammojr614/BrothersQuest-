using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrampScene : MonoBehaviour
{
    public Transform topOfTramp;
    bool JinTramp;
    bool ElinTramp;
    bool LinTramp;
    public GameObject LevelName;

    public List<GameObject> bros = new List<GameObject>();
    private void Start()
    {
        LevelName.SetActive(false);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        //Jamie on Tramp
        if (collision.CompareTag("PlayerJ"))
        {
            JinTramp = true;
            ElinTramp = false;
            LinTramp = false;
            LevelName.SetActive(true);
           
            if (Input.GetKeyDown(KeyCode.W))
            {
                bros[0].transform.position = topOfTramp.position;
                bros[0].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            }
            //El on Tramp
        }else if (collision.CompareTag("PlayerE"))
        {
            JinTramp = false;
            ElinTramp = true;
            LinTramp = false;
            LevelName.SetActive(true);
            if (Input.GetKeyDown(KeyCode.W))
            {
                bros[1].transform.position = topOfTramp.position;
                bros[1].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            }
        }else if (collision.CompareTag("PlayerL"))
        {
            JinTramp = false;
            ElinTramp = false;
            LinTramp = true;
            LevelName.SetActive(true);
            if (Input.GetKeyDown(KeyCode.W))
            {
                bros[2].transform.position = topOfTramp.position;
                bros[2].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            LevelName.SetActive(false);
        }
        if (collision.CompareTag("PlayerE"))
        {
            LevelName.SetActive(false);
        }
        if (collision.CompareTag("PlayerL"))
        {
            LevelName.SetActive(false);
        }
    }
    private void Update()
    {
        //if J is on the tramp
        if (!Input.GetButtonDown("Jump") && BroSwitch.currentBro == 1)
        {
            bros[0].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        } else if (Input.GetButtonDown("Jump") && JinTramp == true)
        {
            bros[0].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            bros[0].transform.Translate(new Vector3(0f, 5f, 0f));
            JinTramp = false;
        }
        //El is on the Tramp
        if(!Input.GetButtonDown("Jump") && BroSwitch.currentBro == 2)
        {
            bros[1].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }else if (Input.GetButtonDown("Jump") && ElinTramp == true)
        {
            bros[1].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            bros[1].transform.Translate(new Vector3(0f, 5f, 0f));
            ElinTramp = false;
        }
        //Lou is on Tramp
        if(!Input.GetButtonDown("Jump") && BroSwitch.currentBro == 3)
        {
            bros[2].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
        }else if(Input.GetButtonDown("Jump") && LinTramp == true)
        {
            bros[2].GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            bros[2].transform.Translate(0f, 5f, 0f);
            LinTramp = false;
        }
        
    }

}
