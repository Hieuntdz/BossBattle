using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoSingleton<MapController>
{
    public GameObject Player;
    public List<Boss> ListBoss = new List<Boss>();
    
    public void DisableAllObject(){
        ListBoss.ForEach(x => x.gameObject.SetActive(false));
    }
    private void ActiveBossByLevel(){
        switch (Facade.Instance.PlayerData.CurrentLevel) {
            case 1:
                ListBoss[0].gameObject.SetActive(true);
                ListBoss[0].transform.position = new Vector3(4.2f, -4.02f,0);
                break;
            case 2:
                ListBoss[1].gameObject.SetActive(true);
                ListBoss[1].transform.position = new Vector3(4.2f, -4.02f,0);
                break;
            case 3:
                ListBoss[2].gameObject.SetActive(true);
                ListBoss[2].transform.position = new Vector3(4.2f, -4.02f,0);
                break;
            case 4:
                ListBoss[3].gameObject.SetActive(true);
                ListBoss[3].transform.position = new Vector3(4.2f, -4.02f,0);
                break;
            case 5:
                ListBoss[4].gameObject.SetActive(true);
                ListBoss[4].transform.position = new Vector3(4.2f, -4.02f,0);
                break;
            default :
                var random = UnityEngine.Random.Range(0, ListBoss.Count);
                ListBoss[random].gameObject.SetActive(true);
                ListBoss[random].transform.position = new Vector3(4.2f, -4.02f,0);
                break;
        }
    }
    public void OnCreateMap(){
        DisableAllObject();
        this.gameObject.SetActive(true);
        ActiveBossByLevel();
    }
}
