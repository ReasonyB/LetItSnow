using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnAvailablePurchase : MonoBehaviour
{
    [SerializeField]
    GameObject CantPurchase;
    
    public void ShowCantPurchase(){
        CantPurchase.SetActive(true);

        Invoke("HideCantPurchase",1);
        
        return;
    }

    private void HideCantPurchase(){
        CantPurchase.SetActive(false);
    }
}
