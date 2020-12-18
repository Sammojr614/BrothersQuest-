using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    playerData plrData = new playerData();
    public Sprite FullHeart;
    public Sprite HalfHeart;
    public Sprite EmptyHeart;
    public List<Image> Hearts = new List<Image>();
    public Text lives;
    private void Update()
    {
        string file = File.ReadAllText(Application.dataPath + "PlayerSaveData.json");
        plrData = JsonUtility.FromJson<playerData>(file);
        lives.text ="x: " + plrData.lives.ToString();
        switch (plrData.health)
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
        }
        if(plrData.health == 0)
        {
            plrData.lives--;
            plrData.health = 6;
            string tojson = JsonUtility.ToJson(plrData);
            JsonUtility.FromJsonOverwrite(tojson, plrData);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", tojson);
        }
        if(plrData.lives <= 0)
        {
            plrData.lives = 0;
            SceneManager.LoadScene("GameOver");
        }
    }
}
