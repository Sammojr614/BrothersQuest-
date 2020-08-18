using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DbManager
{
    private static DbManager dataMgr;
    private DbManager()
    {

    }
    public static DbManager Instance
    {
        get
        {
            if(dataMgr == null)
            {
                dataMgr = new DbManager();
            }
            return dataMgr;
        }
    }
    public int dbHealth;
    public int dbLives;
    public int dbCoins;
    public string dbLocation;
}
