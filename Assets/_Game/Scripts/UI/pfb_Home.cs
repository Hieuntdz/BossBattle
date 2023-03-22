using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public sealed class pfb_Home : UIBehavior
{
    [SerializeField] private Button btnPlay, btnSettings, btnShop, btnShopCoin;
    public TextMeshProUGUI CoinTxt;
    private void Start() {
        btnPlay.onClick.AddListener(onClickBtnPlay);
        btnSettings.onClick.AddListener(onClickBtnSettings);
        btnShop.onClick.AddListener(onClickBtnShop);
        btnShopCoin.onClick.AddListener(delegate{
            UIManager.Instance.pfb_ShopCoin.ActiveNormalPopup(true);
        });
    }
    protected override void UpdateUI()
    {
        base.UpdateUI();
        UpdateCoin();
    }

    public void UpdateCoin(){
        CoinTxt.text = "" + PlayerData.Instance.Coin;
    }
    public void onClickBtnPlay(){
        Facade.Instance.MapController.OnCreateMap();
    }

    public void onClickBtnSettings(){
        UIManager.Instance.pfb_Settings.ActiveNormalPopup(true);
    }
    public void onClickBtnShop(){
        UIManager.Instance.pfb_Shop.ActiveNormalPopup(true);
    }
}
