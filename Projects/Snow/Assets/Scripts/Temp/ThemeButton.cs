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
        curPurchaseTheme = i;
        PPurchase.SetActive(true);
    }
    
    public void OnClickYesSub(){
        int i = curPurchaseTheme;
        
        PPurchase.SetActive(false);
        seasonAvailable[i] = true;
        ResetSeaonButton(i);
        
        //구매 이후 메인씬 전환
        BSeasons[i].GetComponent<Button>()?.onClick.RemoveAllListeners();
        BSeasons[i].GetComponent<Button>()?.onClick.AddListener(()=>SceneManager.LoadScene("Main"));
    }

    public void OnClickNoSub(){
        curPurchaseTheme = -1;
        PPurchase.SetActive(false);
    }

    private void ResetSeaonButton(int i){
        BSeasons[i].transform.GetChild(1).gameObject.SetActive(!seasonAvailable[i]);
    }

}
