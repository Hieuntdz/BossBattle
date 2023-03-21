using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;

public class DataManager
{
    public static string pathInventory = "Inventory";

    // public static void GetDataSkill(ref List<DataSkillBase> ListDataSkillBase){
    //     ListDataSkillBase.Clear();
    //     ListDataSkillBase = new List<DataSkillBase>(ListDataSkillBase.ParseTo(DataController.ReadFromFile(pathInventory)));
    // }

    // public static void SaveDataSkill(ref List<DataSkillBase> ListDataSkillBase){
    //     DataController.WriteToFile(pathInventory, ListDataSkillBase);
    // }
}
