using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DbManager
{
    private static DbManager dbMgr;
    private DbManager()
    {

    }
    public static DbManager Instance
    {
        get
        {
            if(dbMgr == null)
            {
                dbMgr = new DbManager();
            }
            return dbMgr;
        }
        
    }
    public int dbHealth;
    public int dbLives;
    public int dbCurrency;
}
