using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    playerData plrData = new playerData();
    public Text coinDisplay;
    void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        plrData = JsonUtility.FromJson<playerData>(file);
    }

    // Update is called once per frame
    void Update()
    {
        coinDisplay.text = "x: " + plrData.coins.ToString();
    }
}
