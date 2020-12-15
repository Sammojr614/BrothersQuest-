using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DevButton : MonoBehaviour
{
    public Button sammi;
    public AudioSource sound;
    void Start()
    {
        sammi.onClick.AddListener(sound.Play); 
    }

    void playSound()
    {
        sound.Play();
    }
}
