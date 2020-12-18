using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySounds : MonoBehaviour
{
    public List<AudioClip> PlayerSounds = new List<AudioClip>();
    public AudioSource jumpSounds;
    
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathPlain"))
        {
            jumpSounds.clip = PlayerSounds[2];
            jumpSounds.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && BroSwitch.currentBro == 1)
        {
            //Jamie Sounds
            jumpSounds.clip = PlayerSounds[0];
            jumpSounds.Play();
        }else if(Input.GetButtonDown("Jump") && BroSwitch.currentBro == 2)
        {
            //Elliot Sounds
            jumpSounds.clip = PlayerSounds[2];
            jumpSounds.Play();
        }else if(Input.GetButtonDown("Jump") && BroSwitch.currentBro == 3)
        {
            //Lou Sounds
            jumpSounds.clip = PlayerSounds[1];
            jumpSounds.Play();
        }
    }
}
