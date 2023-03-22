using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
public class pfb_Shop : UIBehavior
{
    #region PRODUCT ID
    public static string m_skin01_pack = "m_skin01_pack";

    #endregion
    public List<ItemSkinBullet> ListSkinBullet = new List<ItemSkinBullet>();
    public Button btnClose;
    public List<Sprite> ListSpriteBullet = new List<Sprite>();
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
    #endregion
    private void Start() {
        btnClose.onClick.AddListener(OnClose);
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
