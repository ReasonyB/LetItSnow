using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LISClasses;

public class TimeManager : MonoBehaviour
{

#region Designer Field
    bool customClock = false;
#endregion

    float realTime = 0f;
    GTimer timer = new GTimer();

#region MonoBehaviour Methods
    private void Awake() {
    }
    private void Start() {
    }
    private void Update() {
        realTime += Time.deltaTime;
        
        if(!customClock){
            if(realTime >= 1f){
                realTime -= 1f;
                timer.SetClockNow();
                Debug.Log(timer);
            }
        }
    }
#endregion

}
