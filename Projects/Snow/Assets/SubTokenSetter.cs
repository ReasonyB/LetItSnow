using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static DataManager;

public class SubTokenSetter : MonoBehaviour
{
    [SerializeField]
    Text snow;

    [SerializeField]
    Text petal;

    [SerializeField]
    Text shell;

    [SerializeField]
    Text mapleleaf;

    void Start()
    {
        snow.text = DataManager.Instance.GetSnow().ToString();
        petal.text = DataManager.Instance.GetPetal().ToString();
        shell.text = DataManager.Instance.GetShell().ToString();
        mapleleaf.text = DataManager.Instance.GetMapleleaf().ToString();
    }
}
