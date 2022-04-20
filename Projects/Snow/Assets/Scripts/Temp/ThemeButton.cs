using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ThemeButton : MonoBehaviour
{
    [SerializeField]
    GameObject[] BSeasons = new GameObject[4];
    [SerializeField]
    bool[] seasonAvailable = new bool[4];
    [SerializeField]
    GameObject PPurchase;
    [SerializeField]
    int[] costOfSeason = new int[4];

    int curPurchaseTheme=-1;

    private void Awake() {
        for(int i =0;i<BSeasons.Length;i++){
            ResetSeaonButton(i);
            BSeasons[i].transform.GetChild(1).GetComponentInChildren<Text>().text = costOfSeason[i].ToString();
        }
    }

    public void OnClickSeasonTheme(int i){
        if(!seasonAvailable[i]){
            curPurchaseTheme = i;
            PPurchase.SetActive(true);
        }
        else{
            DataManager.Instance.Theme = i;
            SceneManager.LoadScene("Main");
        }
    }
    
    public void OnClickYesSub(){
        int i = curPurchaseTheme;
        if(!DataManager.Instance.Buy(i,costOfSeason[i])){
            GetComponent<UnAvailablePurchase>()?.ShowCantPurchase();
        }
        else{
            PPurchase.SetActive(false);
            seasonAvailable[i] = true;
            ResetSeaonButton(i);
        }
    }

    public void OnClickNoSub(){
        curPurchaseTheme = -1;
        PPurchase.SetActive(false);
    }

    private void ResetSeaonButton(int i){
        BSeasons[i].transform.GetChild(1).gameObject.SetActive(!seasonAvailable[i]);
    }

}
