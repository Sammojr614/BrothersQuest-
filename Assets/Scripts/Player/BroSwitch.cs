using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class BroSwitch : MonoBehaviour
{
    public static int Bro = 1;
    DbManager dataMgr = DbManager.Instance;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("BroSwitch") && Bro < 3)
        {
            Bro++;
            dataMgr.dbHealth = Health.PlayerHealth;
            dataMgr.dbLives = Health.PlayerLives;
            dataMgr.dbCoins = Coin.PlayerCoins;
            dataMgr.dbBro = Bro;
            if(Bro > 3)
            {
                Bro = 3;
            }
            string jsonStringPos = JsonUtility.ToJson(dataMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json", jsonStringPos);
        }
        if (Input.GetButtonDown("BroSwitchNeg"))
        {
            Bro--;
            dataMgr.dbHealth = Health.PlayerHealth;
            dataMgr.dbLives = Health.PlayerLives;
            dataMgr.dbCoins = Coin.PlayerCoins;
            dataMgr.dbBro = Bro;
            if (Bro < 1)
            {
                Bro = 1;
            }
            string jsonstringNeg = JsonUtility.ToJson(dataMgr);
            File.WriteAllText(Application.dataPath + "PlayerSaveData.json",jsonstringNeg);

        }
    }
}
