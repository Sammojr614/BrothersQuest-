using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int PlayerHealth;
    public static int PlayerLives;
    public List<SpriteRenderer> Hearts = new List<SpriteRenderer>();
    public Sprite FullHeart;
    public Sprite HalfHeart;
    
    
    private void Start()
    {
        string load = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager loadHealth = JsonUtility.FromJson<DbManager>(load);
        PlayerHealth = loadHealth.dbHealth;
        PlayerLives = loadHealth.dbLives;

    }
    private void Update()
    {
        if(PlayerHealth == 2)
        {
            Hearts[0].sprite = FullHeart;
        }else if(PlayerHealth == 1)
        {
            Hearts[0].sprite = HalfHeart;
        }
    }



}
