using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Health : MonoBehaviour
{ 
    public List<SpriteRenderer> Hearts = new List<SpriteRenderer>();
    public Sprite FullHeart;
    public Sprite halfHeart;
    public Sprite emptyHeart;
    public static int playerHealth;
    public static int playerLives;
    private void Start()
    {
        string fromJson = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager load = JsonUtility.FromJson<DbManager>(fromJson);
        playerHealth = load.dbHealth;
        playerLives = load.dbLives;
        
    }
    private void Update()
    {
        if (playerHealth == 6)
        {
            Hearts[2].sprite = FullHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[0].sprite = FullHeart;
        }
    }
}
