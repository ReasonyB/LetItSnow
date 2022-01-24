using System;
using UnityEngine;
using UnityEngine.Events;
using LISEnums;

public class DataManger : MonoBehaviour
{
#region private User Data
    [SerializeField]
    ThemeState curtheme = ThemeState.Winter;
    DateTime endtime = new DateTime();
    bool todaysgift = false;
    int gold = 0;
    int subgold = 0;
#endregion
#region public User Data
#endregion

    UnityAction _Init;

    void Awake() {
        _Init = LoadCurrentTheme;
        
    }
    void Start()
    {
        _Init();
    }

    void Update()
    {
        
    }

    #region User data Manage
    #endregion

    #region User data Save
    private void SaveCurrentTheme(){
        int theme = -1;
        switch(curtheme){
        case ThemeState.Winter:
            theme = 0;
            break;
        case ThemeState.Spring:
            theme = 1;
            break;
        case ThemeState.Summer:
            theme = 2;
            break;
        case ThemeState.Fall:
            theme = 3;
            break;
        }

        PlayerPrefs.SetInt("theme",theme);
    }

    #endregion

    #region User data Load
    private void LoadCurrentTheme(){
        int theme = PlayerPrefs.GetInt("theme",0);
        switch(theme){
        case 0:
            curtheme = ThemeState.Winter;
            break;
        case 1:
            curtheme = ThemeState.Spring;
            break;
        case 2:
            curtheme = ThemeState.Summer;
            break;
        case 3:
            curtheme = ThemeState.Fall;
            break;
        default:
            break;
        }
    }

    #endregion
}
