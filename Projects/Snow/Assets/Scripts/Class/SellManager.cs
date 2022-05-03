using UnityEngine;
using ESubToken;
public class SellManager : MonoBehaviour
{
    [SerializeField]
    GameObject SellPanel;
    Item.Item picked;
    public GameObject getSellPanel() => SellPanel;
    public void SetupPickedItem(Item.Item item)=> picked = item;
#region Buy Methods
    public void Buy()
    {
        if(DataManager.Instance.GoldEnough(picked.Price)){

        }
    }
    public void Buy(int num)
    {
        if(DataManager.Instance.GoldEnough(picked.Price*num)){

        }
    }
    public void Buy(SubToken type){
        if(DataManager.Instance.SubTokenEnough(picked.Price,type)){

        }
    }
#endregion
}
