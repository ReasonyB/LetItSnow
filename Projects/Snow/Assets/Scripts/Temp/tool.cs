using UnityEngine;
using UnityEngine.UI;

public class tool : MonoBehaviour
{
    [SerializeField]
    float goldInc = 1.1f;
    [SerializeField]
    int initGoldPerSec = 10;
    [SerializeField]
    Text goldText;
    [SerializeField]
    Text levelText;

    int goldPerSec;
    float second = 0f;
    int level = 10;
    int totalGold = 0;

    private void Start() {
        levelText.text = "Lv. "+ (level+1);
        goldPerSec  = (int)(initGoldPerSec*Mathf.Pow(goldInc,level));
        Debug.Log(goldPerSec);
    }

    private void Update() {
        second += Time.deltaTime;

        if(second>1f){
            totalGold += goldPerSec;
            second-=1f;
            goldText.text = totalGold.ToString();
        }
    }

}
