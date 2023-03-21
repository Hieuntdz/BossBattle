using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoSingleton<MapController>
{
    public GameObject Player;
    public GameObject Boss_01, Boss_02, Boss_03, Boss_04, Boss_05;
    
    public void DisableAllObject(){
        Boss_01.SetActive(false);
        Boss_02.SetActive(false);
        Boss_03.SetActive(false);
        Boss_04.SetActive(false);
        Boss_05.SetActive(false);
    }
    private void ActiveBossByLevel(){
        switch (Facade.Instance.PlayerData.CurrentLevel) {
            case 1:
                Boss_01.SetActive(true);
                Boss_01.transform.position = new Vector3(2.65f, -3.14f,0);
                break;
            case 2:
                Boss_02.SetActive(true);
                Boss_02.transform.position = new Vector3(2.65f, -3.14f,0);
                break;
            case 3:
                Boss_03.SetActive(true);
                Boss_03.transform.position = new Vector3(2.65f, -3.14f,0);
                break;
            case 4:
                Boss_04.SetActive(true);
                Boss_04.transform.position = new Vector3(2.65f, -3.14f,0);
                break;
            case 5:
                Boss_05.SetActive(true);
                Boss_05.transform.position = new Vector3(2.65f, -3.14f,0);
                break;
            default :
                
                break;
        }
    }
    public void OnCreateMap(){
        DisableAllObject();
        this.gameObject.SetActive(true);
        ActiveBossByLevel();
    }
}
