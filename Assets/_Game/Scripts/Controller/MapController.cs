using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoSingleton<MapController>
{
    public GameObject Player;
    public GameObject Boss_01, Boss_02, Boss_03, Boss_04, Boss_05;
    
    public void DisableAllObject(){
        
    }
    public void OnCreateMap(){
        this.gameObject.SetActive(true);
    }
}
