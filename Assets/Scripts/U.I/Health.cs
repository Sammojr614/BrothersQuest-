using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public static int PlayerHealth;
    public static int PlayerLives;
    public List<SpriteRenderer> Hearts = new List<SpriteRenderer>();
    public Sprite FullHeart;
    public Sprite HalfHeart;
    public Sprite EmptyHeart;
    DbManager healthTracker = DbManager.Instance;
    public Text LivesDisplay;
    
    private void Start()
    {
        string load = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager loadHealth = JsonUtility.FromJson<DbManager>(load);
        PlayerHealth = loadHealth.dbHealth;
        PlayerLives = loadHealth.dbLives;
        

    }
    private void Update()
    {
        healthTracker.dbHealth = PlayerHealth;
        healthTracker.dbLives = PlayerLives;
        healthTracker.dbCoins = Coin.PlayerCoins;
        healthTracker.dbLocation = SceneManager.GetActiveScene().name;
        string tojson = JsonUtility.ToJson(healthTracker);
        File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);
        string healthUpdate = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        DbManager updateHealth = JsonUtility.FromJson<DbManager>(healthUpdate);
        LivesDisplay.text = "Lives: "+ updateHealth.dbLives.ToString();
        if (PlayerHealth == 6)
        {
            Hearts[0].sprite = FullHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = FullHeart;
        } else if (PlayerHealth == 5)
        {
            Hearts[0].sprite = FullHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = HalfHeart;
        } else if (PlayerHealth == 4)
        {
            Hearts[0].sprite = FullHeart;
            Hearts[1].sprite = FullHeart;
            Hearts[2].sprite = EmptyHeart;
        } else if (PlayerHealth == 3)
        {
            Hearts[0].sprite = FullHeart;
            Hearts[1].sprite = HalfHeart;
            Hearts[2].sprite = EmptyHeart;
        } else if (PlayerHealth == 2)
        {
            Hearts[0].sprite = FullHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = EmptyHeart;
        } else if (PlayerHealth == 1)
        {
            Hearts[0].sprite = HalfHeart;
            Hearts[1].sprite = EmptyHeart;
            Hearts[2].sprite = EmptyHeart;
        }else if(PlayerHealth <= 0)
        {
            PlayerLives--;
            PlayerHealth = 6;
        }
        if(PlayerLives < 0) {
            PlayerLives = 0;
            
        }
    


    }
}
