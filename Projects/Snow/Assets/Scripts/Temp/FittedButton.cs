using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FittedButton : MonoBehaviour
{
    private void Awake() {
        int widthButton = (Screen.width-20)/3;

        Debug.Log(transform.GetChild(0).GetComponent<RectTransform>().rect.x); 
    }
}
