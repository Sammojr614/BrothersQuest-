using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cry : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Playclick);
    }
    void Playclick()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}

