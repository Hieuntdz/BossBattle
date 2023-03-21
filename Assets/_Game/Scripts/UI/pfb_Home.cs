using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public sealed class pfb_Home : UIBehavior
{
    [SerializeField] private Button btnPlay, btnSettings, btnShop;

    private void Start() {
        btnPlay.onClick.AddListener(onClickBtnPlay);
        btnSettings.onClick.AddListener(onClickBtnSettings);
        btnShop.onClick.AddListener(onClickBtnShop);
    }

    public void onClickBtnPlay(){

    }

    public void onClickBtnSettings(){
        UIManager.Instance.pfb_Settings.ActiveNormalPopup(true);
    }
    public void onClickBtnShop(){

    }
}
