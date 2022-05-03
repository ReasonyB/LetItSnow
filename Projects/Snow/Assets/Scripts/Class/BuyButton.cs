using UnityEngine;
using UnityEngine.UI;

public class BuyButton : MonoBehaviour
{
    Item.Item item;
    int itemid;
    [SerializeField]
    Image thumbnail;
    [SerializeField]
    GameObject BuyPanel;
    SellManager seller;
#region MonoBehavior Messages
    private void Awake() {
        seller = FindObjectOfType<SellManager>();
        GetComponent<Button>().onClick.AddListener(OnClick);
    }
#endregion
    public void setThumbNail(Item.Item aitem){
        item = aitem;
        //Thumbnail setter
    }
    private void OnClick(){
        seller?.SetupPickedItem(item);
        seller?.getSellPanel().SetActive(true);
    }
}
