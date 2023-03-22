using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
public class pfb_Shop : UIBehavior
{
    #region PRODUCT ID
    public static string m_skin01_pack = "m_skin01_pack";
    public static string m_coin_100 = "m_coin_100";
    public static string m_coin_300 = "m_coin_300";
    public static string m_coin_500 = "m_coin_500";
    public static string m_coin_800 = "m_coin_800";
    public static string m_coin_1000 = "m_coin_1000";
    public static string m_coin_2000 = "m_coin_2000";
    public static string m_coin_2500 = "m_coin_2500";
    public static string m_coin_5000 = "m_coin_5000";
    public static string m_coin_8000 = "m_coin_8000";
    public static string m_coin_10000 = "m_coin_10000";

    #endregion
    public List<ItemSkinBullet> ListSkinBullet = new List<ItemSkinBullet>();
    public Button btnClose;
    public List<Sprite> ListSpriteBullet = new List<Sprite>();
    public static string GetProductId(string id){
        switch (id) {
            case "coin_100":
                return m_coin_100;
            case "coin_300":
                return m_coin_300;
            case "coin_500":
                return m_coin_500;
            case "coin_800":
                return m_coin_800;
            case "coin_1000":
                return m_coin_1000;
            case "coin_2000":
                return m_coin_2000;
            case "coin_2500":
                return m_coin_2500;
            case "coin_5000":
                return m_coin_5000;
            case "coin_8000":
                return m_coin_8000;
            case "coin_10000":
                return m_coin_10000;
            default :
                return m_coin_100;
        }
    }
    protected override void Awake()
    {
        base.Awake();
        //init inapp 
        IAPManager.Instance.OnInitialized += ( success ) =>
        {
            if( success && IAPManager.Instance.IsNonConsumablePurchased( m_skin01_pack ) )
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin01 = 1;
            }else{
                PlayerData.Instance.Unlock_Skin01 = 0;
                if(PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
        };
        IAPManager.Instance.Initialize(new ProductDefinition(m_skin01_pack, ProductType.Subscription));
    }

    #region EVENT CALLBACK PURCHASED
    public void EarnPackSkin_01(){
        PlayerData.Instance.Unlock_Skin01 = 1;
        PlayerData.Instance.Skin_Equipped = 1;
        UIManager.Instance.pfb_Shop.UpdateAllItemSkinBullet();
    }

    public void OnPurchasedCoin(int coin){
        PlayerData.Instance.Coin += coin;
    }
    #endregion
    private void Start() {
        btnClose.onClick.AddListener(OnClose);
        IAPManager.Instance.OnPurchaseCompleted += (product) =>
            {
                if (product.definition.id == m_coin_100)
                    OnPurchasedCoin(100);
                else if (product.definition.id == m_coin_300)
                    OnPurchasedCoin(300);
                else if (product.definition.id == m_coin_500)
                    OnPurchasedCoin(500);
                else if (product.definition.id == m_coin_800)
                    OnPurchasedCoin(800);
                else if (product.definition.id == m_coin_1000)
                    OnPurchasedCoin(1000);
                else if (product.definition.id == m_coin_2000)
                    OnPurchasedCoin(2000);
                else if (product.definition.id == m_coin_2500)
                    OnPurchasedCoin(2500);
                else if (product.definition.id == m_coin_5000)
                    OnPurchasedCoin(5000);
                else if (product.definition.id == m_coin_8000)
                    OnPurchasedCoin(8000);
                else if (product.definition.id == m_coin_10000)
                    OnPurchasedCoin(10000);
            };
    }
    protected override void UpdateUI()
    {
        base.UpdateUI();
        UpdateAllItemSkinBullet();
    }
    public void UpdateAllItemSkinBullet(){
        ListSkinBullet.ForEach(x => x.updateUI());
    }

    public void OnClose(){
        ActiveNormalPopup(false);
    }

    public Sprite GetSkinBullet(int id){
        return ListSpriteBullet[id];
    }
}
