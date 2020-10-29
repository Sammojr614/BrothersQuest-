using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
     //Minimum/Maximum x/y values
    [SerializeField] private float xMin;
    [SerializeField] private float xMax;
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;

    //The player
    [SerializeField] private Transform player;
    public List<Transform> players = new List<Transform>();

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
       
    }

    //Allows the camera to follow the player when they move
    void FollowPlayer()
    {
        if (BroSwitch.Bro == 1)
        {
            player = players[0];
        }else if(BroSwitch.Bro == 2)
        {
            player = players[1];
        }else if(BroSwitch.Bro == 3)
        {
            player = players[2];
        }
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);
       
        
    }
}
