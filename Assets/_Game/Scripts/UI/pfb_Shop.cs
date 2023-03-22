using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
public class pfb_Shop : UIBehavior
{
    public List<ItemSkinBullet> ListSkinBullet = new List<ItemSkinBullet>();
    public Button btnClose;
    public List<Sprite> ListSpriteBullet = new List<Sprite>();
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
