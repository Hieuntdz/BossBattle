using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
public class pfb_Shop : UIBehavior
{
    public List<ItemSkinBullet> ListSkinBullet = new List<ItemSkinBullet>();
    public Button btnClose, btnClose2, btnClose3, btnClose4;
    public List<Sprite> ListSpriteBullet = new List<Sprite>();
    public PopupBuySkin01 PopupBuySkin01;
    public PopupBuySkin07 PopupBuySkin07;
    public PopupBuySkin08 PopupBuySkin08;
    public GameObject PopupBuy;

    public List<PopupNewSkin> ListPopupNewSkin = new List<PopupNewSkin>();
    public void EnablePopupSkin01(bool b)
    {
        PopupBuySkin01.gameObject.SetActive(b);
        PopupBuy.gameObject.SetActive(!b);
    }
    public void EnablePopupSkin07(bool b)
    {
        PopupBuySkin07.gameObject.SetActive(b);
        PopupBuy.gameObject.SetActive(!b);
    }
    public void EnablePopupSkin08(bool b)
    {
        PopupBuySkin08.gameObject.SetActive(b);
        PopupBuy.gameObject.SetActive(!b);
    }
    public void EnablePopupSkin(bool b, int _Id)
    {
        ListPopupNewSkin.Find(x => x.id == _Id).gameObject.SetActive(b);
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
    public static string GetProductId(int id)
    {
        switch (id)
        {
            case 9:
                return Facade.m_skin02_7days_1;
            case 10:
                return Facade.m_skin02_7days_2;
            case 11:
                return Facade.m_skin02_7days_3;
            case 12:
                return Facade.m_skin02_7days_4;
            case 13:
                return Facade.m_skin02_7days_5;
            case 14:
                return Facade.m_skin02_7days_6;
            case 15:
                return Facade.m_skin01_4week;
            case 16:
                return Facade.m_skin01_3month;
            case 17:
                return Facade.m_skin01_6month;
            
            default:
                return Facade.m_coin_100;
        }
    }

    #region EVENT CALLBACK PURCHASED
    public void EarnPackSkin_01()
    {
        PlayerData.Instance.Unlock_Skin01 = 1;
        PlayerData.Instance.Skin_Equipped = 1;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_07()
    {
        PlayerData.Instance.Unlock_Skin07 = 1;
        PlayerData.Instance.Skin_Equipped = 7;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_08()
    {
        PlayerData.Instance.Unlock_Skin08 = 1;
        PlayerData.Instance.Skin_Equipped = 8;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_09()
    {
        PlayerData.Instance.Unlock_Skin09 = 1;
        PlayerData.Instance.Skin_Equipped = 9;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_10()
    {
        PlayerData.Instance.Unlock_Skin10 = 1;
        PlayerData.Instance.Skin_Equipped = 10;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_11()
    {
        PlayerData.Instance.Unlock_Skin11 = 1;
        PlayerData.Instance.Skin_Equipped = 11;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_12()
    {
        PlayerData.Instance.Unlock_Skin12 = 1;
        PlayerData.Instance.Skin_Equipped = 12;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_13()
    {
        PlayerData.Instance.Unlock_Skin13 = 1;
        PlayerData.Instance.Skin_Equipped = 13;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_14()
    {
        PlayerData.Instance.Unlock_Skin14 = 1;
        PlayerData.Instance.Skin_Equipped = 14;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_15()
    {
        PlayerData.Instance.Unlock_Skin15 = 1;
        PlayerData.Instance.Skin_Equipped = 15;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_16()
    {
        PlayerData.Instance.Unlock_Skin16 = 1;
        PlayerData.Instance.Skin_Equipped = 16;
        UpdateAllItemSkinBullet();
    }
    public void EarnPackSkin_17()
    {
        PlayerData.Instance.Unlock_Skin17 = 1;
        PlayerData.Instance.Skin_Equipped = 17;
        UpdateAllItemSkinBullet();
    }
    #endregion
    private void Start()
    {
        btnClose.onClick.AddListener(OnClose);
        btnClose2.onClick.AddListener(OnClose);
        btnClose3.onClick.AddListener(OnClose);
        btnClose4.onClick.AddListener(OnClose);
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
        PopupBuySkin01.gameObject.SetActive(false);
        PopupBuySkin07.gameObject.SetActive(false);
        PopupBuySkin08.gameObject.SetActive(false);
    }

    public Sprite GetSkinBullet(int id)
    {
        return ListSpriteBullet[id];
    }
}
