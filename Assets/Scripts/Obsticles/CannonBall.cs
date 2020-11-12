using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CannonBall : MonoBehaviour
{
    playerSave plrSave = new playerSave();
    public Transform cannonBallSpawn;
    public Transform ballStop;
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        plrSave = JsonUtility.FromJson<playerSave>(file);
        gameObject.transform.position = cannonBallSpawn.transform.position;
    }
    private void Update()
    {
        if(gameObject.transform.position.x <= ballStop.transform.position.x)
        {
            gameObject.transform.position = cannonBallSpawn.transform.position;
        }
        else
        {
            gameObject.transform.Translate(-0.05f, 0, 0);
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            plrSave.savedHealth--;
            string jsonString = JsonUtility.ToJson(plrSave);
            JsonUtility.FromJsonOverwrite(jsonString, plrSave);
            string toFile = JsonUtility.ToJson(plrSave);
            File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
            gameObject.transform.position = cannonBallSpawn.transform.position;
        }
    }
}
