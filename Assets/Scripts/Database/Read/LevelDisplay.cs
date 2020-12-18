using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class LevelDisplay : MonoBehaviour
{
    LvlIndex lvlidx = new LvlIndex();
    public GameObject complete;
    private void Start()
    {
        complete.SetActive(false);
    }
    private void Update()
    {
        string file = File.ReadAllText(Application.dataPath + "LevelIndex.json");
        lvlidx = JsonUtility.FromJson<LvlIndex>(file);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            if (gameObject.name == "Tramp Tutorial" && lvlidx.TutorialDone == true)
            {
                complete.SetActive(false);
            }
            else if (gameObject.name == "toLvl1" && lvlidx.Lvl1Done == true)
            {
                complete.SetActive(false);
            }
        }
        else if (collision.CompareTag("PlayerE"))
        {
            if (gameObject.name == "Tramp Tutorial" && lvlidx.TutorialDone == true)
            {
                complete.SetActive(false);
            }
            else if (gameObject.name == "toLvl1" && lvlidx.Lvl1Done == true)
            {
                complete.SetActive(false);
            }
        }
        else if (collision.CompareTag("PlayerL"))
        {
            if (gameObject.name == "Tramp Tutorial" && lvlidx.TutorialDone == true)
            {
                complete.SetActive(true);
            }
            if (gameObject.name == "toLvl1" && lvlidx.Lvl1Done == true)
            {
                complete.SetActive(true);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            if (gameObject.name == "Tramp Tutorial" && lvlidx.TutorialDone == true)
            {
                complete.SetActive(true);
            }else if(gameObject.name == "toLvl1" && lvlidx.Lvl1Done == true)
            {
                complete.SetActive(true);
            }
        }else if (collision.CompareTag("PlayerE"))
        {
            if (gameObject.name == "Tramp Tutorial" && lvlidx.TutorialDone == true)
            {
                complete.SetActive(true);
            }else if (gameObject.name == "toLvl1" && lvlidx.Lvl1Done == true)
            {
                complete.SetActive(true);
            }
        }
        else if (collision.CompareTag("PlayerL"))
        {
            if (gameObject.name == "Tramp Tutorial" && lvlidx.TutorialDone == true)
            {
                complete.SetActive(true);
            }
            if (gameObject.name == "toLvl1" && lvlidx.Lvl1Done == true)
            {
                complete.SetActive(true);
            }
        }
    }
}
