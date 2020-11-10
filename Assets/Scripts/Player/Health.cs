using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Health : MonoBehaviour
{
    public Sprite FullHeart;
    public Sprite HalfHeart;
    public Sprite EmptyHeart;

    public List<SpriteRenderer> Hearts = new List<SpriteRenderer>();
    // Update is called once per frame
    void Update()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave plrSave = JsonUtility.FromJson<playerSave>(file);

        if (plrSave.savedHealth == 6)
        {
            Hearts[0].sprite = FullHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(plrSave.savedHealth == 5)
        {
            Hearts[0].sprite = HalfHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(plrSave.savedHealth == 4)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(plrSave.savedHealth == 3)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = HalfHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(plrSave.savedHealth == 2)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(plrSave.savedHealth == 1)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = HalfHeart;
        }
        if(plrSave.savedHealth == 0)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = EmptyHeart;
            plrSave.savedLives--;
            plrSave.savedHealth = 6;
            string toJson = JsonUtility.ToJson(plrSave);
            JsonUtility.FromJsonOverwrite(toJson, plrSave);
            string toFile = JsonUtility.ToJson(plrSave);
            File.WriteAllText(Application.dataPath + "playerSaveData.json",toFile);

        }
        if(plrSave.savedHealth < 0)
        {
            plrSave.savedHealth = 0;
            string toJson = JsonUtility.ToJson(plrSave);
            JsonUtility.FromJsonOverwrite(toJson, plrSave);
            string toFile = JsonUtility.ToJson(plrSave);
            File.WriteAllText(Application.dataPath + "playerSaveData.json", toFile);
        }

        
    }
}
