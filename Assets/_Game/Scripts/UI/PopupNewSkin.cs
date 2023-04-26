using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;
public class PopupNewSkin : MonoBehaviour
{
    public Button btnBuy, btnClose;
    public TextMeshProUGUI txtDay;
    public int id;
    public void Close(){
        UIManager.Instance.pfb_Shop.ActiveNormalPopup(false);
        UIManager.Instance.pfb_Shop.PopupBuySkin01.gameObject.SetActive(false);
        UIManager.Instance.pfb_Shop.PopupBuySkin07.gameObject.SetActive(false);
        UIManager.Instance.pfb_Shop.PopupBuySkin08.gameObject.SetActive(false);
        UIManager.Instance.pfb_Shop.ListPopupNewSkin.ForEach(x => x.gameObject.SetActive(false));
    }
    // Start is called before the first frame update
    void Start()
    {
        btnClose.onClick.AddListener(Close);
        IAPManager.Instance.OnPurchaseCompleted += (product) =>
            {
                if (product.definition.id == Facade.m_skin02_7days_1)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_09();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin02_7days_2)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_10();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin02_7days_3)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_11();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin02_7days_4)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_12();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin02_7days_5)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_13();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin02_7days_6)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_14();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin01_4week)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_15();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin01_3month)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_16();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
                if (product.definition.id == Facade.m_skin01_6month)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_17();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin(false, id);
                }
            };
        
        btnBuy.onClick.AddListener(OnBuy);
        InitIAP();
    }
    public void InitIAP() {
        if (IAPManager.Instance.IsInitialized)
        {
            txtDay.text = "7 Days/" + IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId(id));
            if(id == 15)
                txtDay.text = "4 Weeks/" + IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId(id));
            else if(id == 16)
                txtDay.text = "3 Months/" + IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId(id));
            else if(id == 17)
                txtDay.text = "6 Months/" + IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId(id));
            btnBuy.interactable = true;
        }
        else {
            btnBuy.interactable = false;
        }
    }
    void OnBuy()
    {
        IAPManager.Instance.Purchase(pfb_Shop.GetProductId(id), () => Time.timeScale = 1f );
    }

}
