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
        playerSave savedData = JsonUtility.FromJson<playerSave>(file);
        if(savedData.savedHealth == 6)
        {
            Hearts[0].sprite = FullHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(savedData.savedHealth == 5)
        {
            Hearts[0].sprite = HalfHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(savedData.savedHealth == 4)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(savedData.savedHealth == 3)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = HalfHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(savedData.savedHealth == 2)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = FullHeart;
        }
        if(savedData.savedHealth == 1)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = HalfHeart;
        }
        if(savedData.savedHealth == 0)
        {
            Hearts[0].sprite = EmptyHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = EmptyHeart;
        }
    }
}
