using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visBro : MonoBehaviour
{
    public List<GameObject> brothers = new List<GameObject>();
    private void Update()
    {
        if (BroSwitch.Bro == 1)
        {
            brothers[0].SetActive(true);
            brothers[1].SetActive(false);
            brothers[2].SetActive(false);
        } else if (BroSwitch.Bro == 2)
        {
            brothers[1].SetActive(true);
            brothers[0].SetActive(false);
            brothers[2].SetActive(false);

        } else if (BroSwitch.Bro == 3)
        {
            brothers[1].SetActive(false);
            brothers[0].SetActive(false);
            brothers[2].SetActive(true);
        }
    }

}
