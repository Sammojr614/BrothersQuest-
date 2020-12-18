using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Createlvlind : MonoBehaviour
{
    private void Update()
    {
        if(!File.Exists(Application.dataPath + "LevelIndex.json"))
        {
            LvlIndex lvlidx = new LvlIndex();
            lvlidx.TutorialDone = false;
            lvlidx.Lvl1Done = false;
            lvlidx.Lvl2Done = false;
            lvlidx.Lvl3Done = false;
            string toJson = JsonUtility.ToJson(lvlidx);
            File.WriteAllText(Application.dataPath + "LevelIndex.json", toJson);
        }
    }
}
