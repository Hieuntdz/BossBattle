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
        if(Facade.Instance.PlayerData.CurrentLevel > 5){
            var random = UnityEngine.Random.Range(0, ListBoss.Count);
            ListBoss[random].gameObject.SetActive(true);
            ListBoss[random].transform.position = new Vector3(4.2f, -4.02f,0);
            ListBoss[random].GetComponent<BossHealth>().health = 500;
        }else{
            ListBoss[Facade.Instance.PlayerData.CurrentLevel-1].gameObject.SetActive(true);
            ListBoss[Facade.Instance.PlayerData.CurrentLevel-1].GetComponent<BossHealth>().health = 500;
        }
    }
    public void OnCreateMap(){
        UIManager.Instance.pfb_GamePlay.ActivePopup(true);
        DisableAllObject();
        this.gameObject.SetActive(true);
        ActiveBossByLevel();
    }
}
