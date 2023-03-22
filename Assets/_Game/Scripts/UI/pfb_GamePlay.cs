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
        btnLeft.onClick.AddListener(OnClickLeft);
        btnRight.onClick.AddListener(OnClickRight);
        btnUp.onClick.AddListener(OnClickUp);
        btnAttack.onClick.AddListener(OnClickAttack);
    }

    private void OnClickBack(){
        MapController.Instance.gameObject.SetActive(false);
        UIManager.Instance.pfb_Home.ActivePopup(true);
    }
    protected override void UpdateUI()
    {
        base.UpdateUI();
        LevelText.text = "Level " + PlayerData.Instance.CurrentLevel;
    }
    private void OnClickLeft(){

    }
    public void OnLeft(){
        PlayerMovement.dirMove = -1;
    }
    public void OnRight(){
        PlayerMovement.dirMove = 1;
    }
    private void OnClickRight(){

    }

    private void OnClickUp(){
        MapController.Instance.PlayerMovement.Jump();
    }

    private void OnClickAttack(){
        MapController.Instance.PrefabWeapon.Shoot();
    }
}
