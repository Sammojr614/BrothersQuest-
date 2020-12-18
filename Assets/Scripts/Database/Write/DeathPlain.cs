using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DeathPlain : MonoBehaviour
{
    playerData plrData = new playerData();
    public Transform Spawn;
    public List<Transform> bros;
    private void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        plrData = JsonUtility.FromJson<playerData>(file);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            plrData.health--;
            string toJson = JsonUtility.ToJson(plrData);
            JsonUtility.FromJsonOverwrite(toJson, plrData);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json",toJson);
            bros[0].transform.position = Spawn.position;

        }
        if (collision.CompareTag("PlayerE"))
        {
            plrData.health--;
            string toJson = JsonUtility.ToJson(plrData);
            JsonUtility.FromJsonOverwrite(toJson, plrData);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", toJson);
            bros[1].transform.position = Spawn.position;
        }
        if (collision.CompareTag("PlayerL"))
        {
            plrData.health--;
            string toJson = JsonUtility.ToJson(plrData);
            JsonUtility.FromJsonOverwrite(toJson, plrData);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", toJson);
            bros[2].transform.position = Spawn.position;
        }
    }

}
