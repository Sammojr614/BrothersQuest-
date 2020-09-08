using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BroLock : MonoBehaviour
{
    public int lockedBro;
    // Update is called once per frame
    void Update()
    {
        BroSwitch.Bro = lockedBro;
    }
}
