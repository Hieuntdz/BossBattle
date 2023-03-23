using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
public class pfb_Shop : UIBehavior
{
    public List<ItemSkinBullet> ListSkinBullet = new List<ItemSkinBullet>();
    public Button btnClose, btnClose2;
    public List<Sprite> ListSpriteBullet = new List<Sprite>();
    public PopupBuySkin01 PopupBuySkin01;
    public GameObject PopupBuy;
    public void EnablePopupSkin01(bool b)
    {
        PopupBuySkin01.gameObject.SetActive(b);
        PopupBuy.gameObject.SetActive(!b);
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        EnablePopupSkin01(false);
    }
    public static string GetProductId(string id)
    {
        switch (id)
        {
            case "coin_100":
                return Facade.m_coin_100;
            case "coin_300":
                return Facade.m_coin_300;
            case "coin_500":
                return Facade.m_coin_500;
            case "coin_800":
                return Facade.m_coin_800;
            case "coin_1000":
                return Facade.m_coin_1000;
            case "coin_2000":
                return Facade.m_coin_2000;
            case "coin_2500":
                return Facade.m_coin_2500;
            case "coin_5000":
                return Facade.m_coin_5000;
            case "coin_8000":
                return Facade.m_coin_8000;
            case "coin_10000":
                return Facade.m_coin_10000;
            case "day_7":
                return Facade.m_skin01_7day;
            case "day_30":
                return Facade.m_skin01_1month;
            case "day_365":
                return Facade.m_skin01_1year;
            default:
                return Facade.m_coin_100;
        }
    }

    #region EVENT CALLBACK PURCHASED
    public void EarnPackSkin_01()
    {
        PlayerData.Instance.Unlock_Skin01 = 1;
        PlayerData.Instance.Skin_Equipped = 1;
        UIManager.Instance.pfb_Shop.UpdateAllItemSkinBullet();
    }
    #endregion
    private void Start()
    {
        btnClose.onClick.AddListener(OnClose);
        btnClose2.onClick.AddListener(OnClose);
    }
    protected override void UpdateUI()
    {
        base.UpdateUI();
        UpdateAllItemSkinBullet();
    }
    public void UpdateAllItemSkinBullet()
    {
        ListSkinBullet.ForEach(x => x.updateUI());
    }

    public void OnClose()
    {
        ActiveNormalPopup(false);
    }

    public Sprite GetSkinBullet(int id)
    {
        return ListSpriteBullet[id];
    }
}
