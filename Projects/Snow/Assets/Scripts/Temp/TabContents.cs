using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabContents : MonoBehaviour
{
    int shownCP = 0;

    private void OnEnable() {
        ChangeCP(shownCP);
    }
    
    private void ChangeCP(int i){
        if(shownCP!=i){
            transform.GetChild(shownCP)?.gameObject.SetActive(false);        
        }
        transform.GetChild(i)?.gameObject.SetActive(true);
        shownCP = i;
    }

    public void OnClickShowCP(int cpno){
        ChangeCP(cpno);
    }

}
