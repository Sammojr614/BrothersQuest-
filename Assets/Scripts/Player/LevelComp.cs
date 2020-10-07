using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComp : MonoBehaviour
{
    public static int LevelsComplete;
    public GameObject TeamWorkTri;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LevelsComplete++;
            TeamWorkTri.SetActive(false);
        }
    }
}
