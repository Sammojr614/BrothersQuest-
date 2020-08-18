using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    private void Update()
    {
        if(Health.PlayerLives <= 0)
        {
            SceneManager.LoadScene("GameOver");
            Cursor.visible = true;
        }
    }
}
