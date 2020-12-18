using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Camera Bounds
    [SerializeField] private float Xmin;
    [SerializeField] private float Xmax;
    [SerializeField] private float Ymin;
    [SerializeField] private float Ymax;


    //Player
  
    public List<Transform> bros = new List<Transform>();
    //invis Walls
    public Transform leftWall;
    public Transform rightWall;


    // Update is called once per frame
    void Update()
    {
        Xmin = leftWall.position.x;
        Xmax = rightWall.position.x;
        
        FollowPlayer();

    }

    void FollowPlayer()
    {
        switch (BroSwitch.currentBro)
        {
            case 1:
                float jx = Mathf.Clamp(bros[0].transform.position.x, Xmin, Xmax);
                float jy = Mathf.Clamp(bros[0].transform.position.y, Ymin, Ymax);
                gameObject.transform.position = new Vector3(jx, jy, gameObject.transform.position.z);
                break;
            case 2:
                float Ex = Mathf.Clamp(bros[1].transform.position.x, Xmin, Xmax);
                float Ey = Mathf.Clamp(bros[1].transform.position.y, Ymin, Ymax);
                gameObject.transform.position = new Vector3(Ex, Ey, gameObject.transform.position.z);
                break;
            case 3:
                float Lx = Mathf.Clamp(bros[2].transform.position.x, Xmin, Xmax);
                float Ly = Mathf.Clamp(bros[2].transform.position.y, Ymin, Ymax);
                gameObject.transform.position = new Vector3(Lx, Ly, gameObject.transform.position.z);
                break;
        }
      
    }

}

