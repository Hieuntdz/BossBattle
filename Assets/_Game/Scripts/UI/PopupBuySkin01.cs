using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using TMPro;
public class PopupBuySkin01 : MonoBehaviour
{
    public Button btnBuy7Day, btnBuy1Month, btnBuy1Year;
    public TextMeshProUGUI txt7day, txt1month, txt1year;
    // Start is called before the first frame update
    void Start()
    {
        IAPManager.Instance.OnPurchaseCompleted += (product) =>
            {
                if (product.definition.id == Facade.m_skin01_7day ||
                product.definition.id == Facade.m_skin01_1month ||
                product.definition.id == Facade.m_skin01_1year
                )
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_01();
                    UIManager.Instance.pfb_Shop.EnablePopupSkin01(false);
                }
            };
        
        btnBuy7Day.onClick.AddListener(OnBuy7Day);
        btnBuy1Month.onClick.AddListener(OnBuy1Month);
        btnBuy1Year.onClick.AddListener(OnBuy1Year);
        InitIAP();
    }
    public void InitIAP() {
        if (IAPManager.Instance.IsInitialized)
        {
            txt7day.text = "7 Days/" + IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId("day_7"));
            txt1month.text = "1 Month/" +IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId("day_30"));
            txt1year.text = "1 Year/" +IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId("day_365"));
            btnBuy7Day.interactable = true;
            btnBuy1Month.interactable = true;
            btnBuy1Year.interactable = true;
        }
        else {
            btnBuy7Day.interactable = false;
            btnBuy1Month.interactable = false;
            btnBuy1Year.interactable = false;
        }
    }
    void OnBuy7Day()
    {
        IAPManager.Instance.Purchase(Facade.m_skin01_7day, () => Time.timeScale = 1f );
    }

    void OnBuy1Month()
    {
        IAPManager.Instance.Purchase(Facade.m_skin01_1month, () => Time.timeScale = 1f );
    }

    void OnBuy1Year()
    {
        IAPManager.Instance.Purchase(Facade.m_skin01_1year, () => Time.timeScale = 1f );
    }
}
