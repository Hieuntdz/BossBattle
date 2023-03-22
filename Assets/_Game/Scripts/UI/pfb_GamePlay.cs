using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class pfb_GamePlay : UIBehavior
{
    public HealthBar HealthBar;
    public Button btnBack, btnLeft, btnRight, btnUp, btnAttack;
    public TextMeshProUGUI LevelText;
    private void Start() {
        btnBack.onClick.AddListener(OnClickBack);
    }

    private void OnClickBack(){
        MapController.Instance.gameObject.SetActive(false);
        UIManager.Instance.pfb_Home.ActivePopup(true);
    }
    protected override void UpdateUI()
    {
        base.UpdateUI();
        LevelText.text = "Level " + PlayerData.Instance.CurrentLevel;
        HealthBar.SetBossHealth(MapController.Instance.ListBoss[PlayerData.Instance.CurrentLevel - 1].GetComponent<BossHealth>());
    }
    private void OnClickLeft(){

    }

    private void OnClickRight(){

    }

    private void OnClickUp(){

    }

    private void OnClickAttack(){
        
    }
}
