using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MakeLvlindex : MonoBehaviour
{
    LevelIdex LvlIndex = new LevelIdex();
    private void Start()
    {
        if (!File.Exists(Application.dataPath + "levelIndex.json"))
        {
            LvlIndex.Lvl1Complete = false;
            LvlIndex.Lvl2Complete = false;
            LvlIndex.Lvl3Complete = false;
            string toJson = JsonUtility.ToJson(LvlIndex);
            File.WriteAllText(Application.dataPath + "levelIndex.json", toJson);
        }
    }
}
