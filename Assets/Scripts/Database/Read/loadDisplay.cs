using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class loadDisplay : MonoBehaviour
{
    playerData readData = new playerData();
    public Text livesDisplay;
    public Text Coins;
    public Sprite FullHeart;
    public Sprite HalfHeart;
    public Sprite EmptyHeart;
    public List<SpriteRenderer> Hearts = new List<SpriteRenderer>();
    public Button LoadButton;

    void Start()
    {
        string file = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        readData = JsonUtility.FromJson<playerData>(file);
        LoadButton.onClick.AddListener(gotoScene);
        
    }
    void gotoScene()
    {
        SceneManager.LoadScene(readData.location);
    }

   
    void Update()
    {
        livesDisplay.text ="Lives: " + readData.lives.ToString();
        Coins.text = "x: " + readData.coins.ToString();
        switch (readData.health)
        {
            case 6:
                Hearts[0].sprite = FullHeart;
                Hearts[1].sprite = FullHeart;
                Hearts[2].sprite = FullHeart;
                break;
            case 5:
                Hearts[0].sprite = HalfHeart;
                Hearts[1].sprite = FullHeart;
                Hearts[2].sprite = FullHeart;
                break;
            case 4:
                Hearts[0].sprite = EmptyHeart;
                Hearts[1].sprite = FullHeart;
                Hearts[2].sprite = FullHeart;
                break;
            case 3:
                Hearts[0].sprite = EmptyHeart;
                Hearts[1].sprite = HalfHeart;
                Hearts[2].sprite = FullHeart;
                break;
            case 2:
                Hearts[0].sprite = EmptyHeart;
                Hearts[1].sprite = EmptyHeart;
                Hearts[2].sprite = FullHeart;
                break;
            case 1:
                Hearts[0].sprite = EmptyHeart;
                Hearts[1].sprite = EmptyHeart;
                Hearts[2].sprite = HalfHeart;
                break;
            case 0:
                Hearts[0].sprite = EmptyHeart;
                Hearts[1].sprite = EmptyHeart;
                Hearts[2].sprite = EmptyHeart;
                break;

        }
    }
}
