using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using LISClasses;

public class CSVReader : MonoBehaviour
{
    static List<Dictionary<string, string>> gameData = new List<Dictionary<string, string>>();
    static Dictionary<int,Food> foods;

    private void Awake() {
        ReadCSV();
    }
    public static void ReadCSV(/*string filepath*/){
        string[] context = null;
        context = ((Resources.Load("Food") as TextAsset).text).Split('\n');
                
        STRING_TAGS.FOOD_TAGS = context[0].Split(',');

        for(int i =1;i<context.Length-1;i++){
            Dictionary<string,string> item = new Dictionary<string, string>();
            string[] values = context[i].Split(',');
            
            for(int j = 0;j<STRING_TAGS.FOOD_TAGS.Length;j++){
                item.Add(STRING_TAGS.FOOD_TAGS[j],values[j]);
                Debug.Log(STRING_TAGS.FOOD_TAGS[j]+", "+values[j]);
            }
        }
    }
    
    public static void MakeFoodDictionary(){
        Dictionary<int,Food> items = new Dictionary<int, Food>();
        for(int i =0;i<gameData.Count;i++){
            
        }
        
    }
}
