using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public string sceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerJ"))
        {
            SceneManager.LoadScene(sceneName);
        }
        if (collision.CompareTag("PlayerE"))
        {
            SceneManager.LoadScene(sceneName);
        }
        if (collision.CompareTag("PlayerL"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
