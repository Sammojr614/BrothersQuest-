using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBro : MonoBehaviour
{
    public List<Transform> Transformlist;

    // Update is called once per frame
    void Update()
    {
        if(BroSwitch.Bro == 1)
        {
            gameObject.transform.position = Transformlist[0].position;
        }else if(BroSwitch.Bro == 2)
        {
            gameObject.transform.position = Transformlist[1].position;
        }else if(BroSwitch.Bro == 3)
        {
            gameObject.transform.position = Transformlist[2].position;
        }
    }
}
