using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerTut : MonoBehaviour
{
    public Button Yes;
    public Button No;
    public static bool playerHasPlayed;
    private void Start()
    {
        Yes.onClick.AddListener(yesClick);
        No.onClick.AddListener(noClick);
    }
    void yesClick()
    {
        SceneManager.LoadScene("Testing");
        playerHasPlayed = true;
    }
    void noClick()
    {
        SceneManager.LoadScene("Tut1");
        playerHasPlayed = false;
    }
}
