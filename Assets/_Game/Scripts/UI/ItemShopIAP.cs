using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ItemShopIAP : MonoBehaviour
{
    public int DefaultPrice = 20000;
    public int CoinNumber = 100;
    public TextMeshProUGUI CoinText, PriceText;
    public Button btnBuy;
    public string id;
    // Start is called before the first frame update
    void Start()
    {
        CoinText.text = "" + CoinNumber;
        InitIAP();
        btnBuy.onClick.AddListener(OnBuy);
    }
    public void OnBuy(){
        IAPManager.Instance.Purchase(pfb_Shop.GetProductId(id), () => Time.timeScale = 1f );
    }
    public void InitIAP() {
        if (IAPManager.Instance.IsInitialized)
        {
            PriceText.text = IAPManager.Instance.GetLocalizedPriceString(pfb_Shop.GetProductId(id));
            btnBuy.interactable = true;
        }
        else {
            PriceText.text = "" + DefaultPrice;
            btnBuy.interactable = false;
        }
    }
}
