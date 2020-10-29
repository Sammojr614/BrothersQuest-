using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class loadButton : MonoBehaviour
{
    Button loadPress;
    // Start is called before the first frame update
    void Start()
    {
        loadPress = gameObject.GetComponent<Button>();
        loadPress.onClick.AddListener(loadOnClick);
    }

    void loadOnClick()
    {
        string file = File.ReadAllText(Application.dataPath + "playerSaveData.json");
        playerSave savedData = JsonUtility.FromJson<playerSave>(file);
        SceneManager.LoadScene(savedData.savedLocation);
    }
}
