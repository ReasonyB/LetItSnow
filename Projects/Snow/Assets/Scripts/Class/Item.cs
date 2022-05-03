using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ESubToken;

namespace Item{
#region Enum for Costume
    public enum CostumeType{Head,Top,Bottom,Shoes};
#endregion
#region Serializable Class for Saving
    public class SerializeFieldItem {
        [SerializeField]
        public int ID{get;}
        [SerializeField]
        int amount;
        [SerializeField]
        int index;
    }
#endregion
#region Root Class of Item
    public class Item : SerializeFieldItem
    { //FROM Data Sheet
        public string Name{get;}
        public string Detail{get;}
        string thumbpath;
        protected int maxamount;
    #region Variable to Property
        public int Price{get;}
    #endregion
        public virtual void Use(){
            Debug.Log($"Used {Name}");
        }

    }
#endregion
#region Sub Classes by Variable Classes
    public class Food : Item
    {
        int unlocklevel;
        int healamount;
        public Food(){
            maxamount = 1;
        }
        public override void Use()
        {
            base.Use();
            //Compare
        }
    }
    public class Costume : Item{
        //Constructor need Array Address
        //Array Address Pointer Variable
        bool isOnUse;
        CostumeType part;
        SubToken tokentype;
        public override void Use()
        {
            base.Use();
        }
        public void PostTakeOff(){}
        public void PostPutOn(){}
    }
#endregion
}