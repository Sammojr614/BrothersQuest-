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
    public int dbBro;
}
public class LevelIndex
{
    private static LevelIndex LvlIndx;
    private LevelIndex()
    {

    }
    public static LevelIndex Instance
    {
        get
        {
            if(LvlIndx == null)
            {
                LvlIndx = new LevelIndex();
            }
            return LvlIndx;
        }
    }
    public bool Lvl1Comp;
    public bool Lvl2Comp;
    public bool Lvl3Comp;
}