using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanelController : MonoBehaviour
{
    [SerializeField]
    GameObject PStoreNInventory;
    [SerializeField]
    GameObject PItemUseOrBuy;


#region OnClick Methods
    public void OnClickStoreOrInvetory(bool isStore){
        PStoreNInventory.SetActive(true);
        
        if(isStore){
            //상점이면 띄울 아이템들
        }
        else{
            //인벤토리면 띄울 아이템들
        }
    }
    
    public void OnClickBackToMain(){
        PStoreNInventory.SetActive(false);
    }

    public void OnClickItemInfo(int i){
        //PItemUseOrBuy.GetComponent<>
    }

#endregion

}
