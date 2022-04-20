using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadEmblem : MonoBehaviour
{
    [SerializeField]
    Image seasonToken;
    // Start is called before the first frame update
    void Start()
    {
        string seasonName = "";
        switch(DataManager.Instance.Theme){
        case 0:
            seasonName = "spring";
            break;
        case 1:
            seasonName = "summer";
            break;
        case 2:
            seasonName = "fall";
            break;
        default:
            seasonName = "winter";
            Debug.Log($"Theme From LoadEmblem: {DataManager.Instance.Theme}");
            break;
        }

        seasonToken.sprite = Resources.Load<Sprite>("IMG/Currency/"+seasonName);
    }

}
