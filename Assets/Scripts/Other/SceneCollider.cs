using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneCollider : MonoBehaviour
{
    public string sceneName;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("PlayerJ"))
        {
            SceneManager.LoadScene(sceneName);
        }
        if (collision.collider.CompareTag("PlayerE"))
        {
            SceneManager.LoadScene(sceneName);
        }
        if (collision.collider.CompareTag("PlayerL"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
