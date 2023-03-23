using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoSingleton<MapController>
{
    public PlayerHealth Player;
    public PlayerMovement PlayerMovement;
    public PrefabWeapon PrefabWeapon;
    public List<Boss> ListBoss = new List<Boss>();
    protected override void Awake()
    {
        base.Awake();
        gameObject.SetActive(false);
    }
    public void DisableAllObject(){
        Player.gameObject.SetActive(false);
        ListBoss.ForEach(x => x.gameObject.SetActive(false));
    }
    private void ActiveBossByLevel(){
        if(Facade.Instance.PlayerData.CurrentLevel > 5){
            var random = UnityEngine.Random.Range(0, ListBoss.Count);
            ListBoss[random].gameObject.SetActive(true);
            ListBoss[random].transform.position = new Vector3(4.2f, -4.02f,0);
            ListBoss[random].GetComponent<BossHealth>().health = 500;
            UIManager.Instance.pfb_GamePlay.HealthBar.SetBossHealth(ListBoss[random].GetComponent<BossHealth>());
        }else{
            ListBoss[Facade.Instance.PlayerData.CurrentLevel-1].gameObject.SetActive(true);
            ListBoss[Facade.Instance.PlayerData.CurrentLevel-1].transform.position = new Vector3(4.2f, -4.02f,0);
            ListBoss[Facade.Instance.PlayerData.CurrentLevel-1].GetComponent<BossHealth>().health = 500;
            UIManager.Instance.pfb_GamePlay.HealthBar.SetBossHealth(ListBoss[Facade.Instance.PlayerData.CurrentLevel-1].GetComponent<BossHealth>());
        }
    }
    public void OnCreateMap(){
        UIManager.Instance.pfb_GamePlay.ActivePopup(true);
        this.gameObject.SetActive(true);
        DisableAllObject();
        ActiveBossByLevel();
        Player.OnReset();
        Player.transform.position = new Vector3(-3.64f, -2.48f, 0);
        Player.gameObject.SetActive(true);
        UIManager.Instance.pfb_GamePlay.PlayerHealthBarController.DoAnimHealth();
    }
}
