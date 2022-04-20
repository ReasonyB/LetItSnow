using UnityEngine;
using UnityEngine.UI;

public class ContructItemPanel : MonoBehaviour
{
    [SerializeField]
    Image icon;
    [SerializeField]
    Text info;
    [SerializeField]
    Button yes;
    [SerializeField]
    Button no;
    [SerializeField]
    Button back;

    //Item class 변수
    int item;
    
    private void Awake() {
        yes.onClick.AddListener(()=>Buy());
        yes.onClick.AddListener(()=>SetPanelUnvisible());
        no.onClick.AddListener(()=>SetPanelUnvisible());
        back.onClick.AddListener(()=>SetPanelUnvisible());
    }
    
    public void SetItem(int i){
        item = i;
    }
    
    private void SetItemInfoToUI(){
        
    }

    private void Buy(){}

    private void SetPanelUnvisible()=> gameObject.SetActive(false);
}
