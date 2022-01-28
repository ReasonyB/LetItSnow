using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Meter : MonoBehaviour
{
    public Text text;
    private float meter = 0f;
    private float onesec = 0f;
    private void Update() {
        onesec += Time.deltaTime;

        if(onesec>=1f){
            meter += 0.1f*onesec;
            text.text = string.Format("{0:f2}m",meter);
            onesec = 0f;
        }

        
    }
}
