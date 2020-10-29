using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class LivesDisplay : MonoBehaviour
{
    public SpriteRenderer livesRenderer;
    public Text lives;

    public Sprite J;
    public Sprite E;
    public Sprite Lou;

    // Update is called once per frame
    void Update()
    {
        if(BroSwitch.Bro == 1)
        {
            livesRenderer.sprite = J;
        }else if(BroSwitch.Bro == 2)
        {
            livesRenderer.sprite = E;
        }else if(BroSwitch.Bro == 3)
        {
            livesRenderer.sprite = Lou;
        }
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave plrDb = JsonUtility.FromJson<playerSave>(file);
        lives.text = "x: " + plrDb.savedLives.ToString();
    }
}
