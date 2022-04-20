using System;
using UnityEngine;

public class DataManager 
{
#region private User Data
    int curtheme = 0;
    DateTime endtime = new DateTime();
    bool todaysgift = false;
    int gold = 0;
    int[] subtoken = new int[4];
#endregion

#region public User Data
#endregion

#region Csharp Singleton
    private static DataManager _instance;
    public static DataManager Instance{
        get{
            if(_instance == null) _instance = new DataManager();
            return _instance;
        }
    }
    public DataManager(){
        LoadCurrentTheme();
        LoadGold();
        LoadSubToken();
    }
#endregion

#region User data Manage
    public int GetSnow()=>subtoken[0];
    public int GetPetal()=>subtoken[1];
    public int GetShell()=>subtoken[2];
    public int GetMapleleaf()=>subtoken[3];
#endregion

#region User data Save
    private void SaveCurrentTheme(){
        PlayerPrefs.SetInt("theme",curtheme);
    }

    private void SaveGold(){
        PlayerPrefs.SetInt("gold", gold);
    }
    
    private void SaveSubToken(){
        PlayerPrefs.SetInt("winter",subtoken[0]);
        PlayerPrefs.SetInt("spring",subtoken[1]);
        PlayerPrefs.SetInt("summer",subtoken[2]);
        PlayerPrefs.SetInt("fall",subtoken[3]);
    }

#endregion

#region User data Load
private void LoadCurrentTheme(){
    curtheme = PlayerPrefs.GetInt("theme",0);
}

private void LoadGold(){
    gold = PlayerPrefs.GetInt("gold",-1);
}

private void LoadSubToken(){
    subtoken[0] = PlayerPrefs.GetInt("winter",-1);
    subtoken[1] = PlayerPrefs.GetInt("spring",-1);
    subtoken[2] = PlayerPrefs.GetInt("summer",-1);
    subtoken[3] = PlayerPrefs.GetInt("fall",-1);
}
#endregion

#region Purchase Utilities
    public bool Buy(int index, int price){
        if(subtoken[index]>=price){
            subtoken[index]-=price;
            return true;
        }
        return false;
    }
#endregion

#region Theme Utilities
    public int Theme{
        get=>curtheme;
        set=>curtheme = value;
    }
#endregion
}
