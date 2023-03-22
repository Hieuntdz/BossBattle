using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ItemSkinBullet : MonoBehaviour
{
    public int Id;
    public Button btnClick;
    public int coin = 100;
    [SerializeField] private bool isEquipped = false;
    public Image Lock;
    public GameObject TextEquipped, CoinIcon;
    public TextMeshProUGUI CoinTxt;
    private void Start()
    {
        btnClick.onClick.AddListener(OnClick);
        CoinTxt.text = "" + coin;
        if (Id == 1)
        {
            IAPManager.Instance.OnPurchaseCompleted += (product) =>
            {
                if (product.definition.id == Facade.m_skin01_pack)
                {
                    // product is successfully purchased!
                    UIManager.Instance.pfb_Shop.EarnPackSkin_01();
                }
            };
        }
    }
    public void updateUI()
    {
        if (PlayerData.Instance.Skin_Equipped == Id)
            isEquipped = true;
        else
            isEquipped = false;
        if (GetDataSkinById() == 1)
        {
            Lock.gameObject.SetActive(false);
            CoinIcon.SetActive(false);
            CoinTxt.gameObject.SetActive(false);
            if (isEquipped)
                TextEquipped.SetActive(true);
            else
                TextEquipped.SetActive(false);
        }
        else
        {
            Lock.gameObject.SetActive(true);
            TextEquipped.SetActive(false);
            if(Id != 1){
                CoinIcon.SetActive(true);
                CoinTxt.gameObject.SetActive(true);
            }else{
                CoinIcon.SetActive(false);
                CoinTxt.gameObject.SetActive(false);
            }
            
        }
    }
    private void OnClick()
    {
        if (GetDataSkinById() == 1)
        {
            PlayerData.Instance.Skin_Equipped = Id;
            UIManager.Instance.pfb_Shop.UpdateAllItemSkinBullet();
        }
        else
        {
            //purchase or buy with coin
            //Kiểm tra nếu là skin số 01 thì purchase, còn lại check coin
            if (Id == 1)
                IAPManager.Instance.Purchase(Facade.m_skin01_pack, () => Time.timeScale = 1f );
            else
                OnBuy();
        }
    }
    public void OnBuy(){
        if(PlayerData.Instance.Coin < this.coin){
            //deo du tien
        }else{  
            PlayerData.Instance.Coin -= this.coin;
            PlayerData.Instance.Skin_Equipped = Id;
            UIManager.Instance.pfb_Shop.UpdateAllItemSkinBullet();
        }
    }
    
    public int GetDataSkinById()
    {
        switch (Id)
        {
            case 0:
                return PlayerData.Instance.Unlock_Skin00;
            case 1:
                return PlayerData.Instance.Unlock_Skin01;
            case 2:
                return PlayerData.Instance.Unlock_Skin02;
            case 3:
                return PlayerData.Instance.Unlock_Skin03;
            case 4:
                return PlayerData.Instance.Unlock_Skin04;
            case 5:
                return PlayerData.Instance.Unlock_Skin05;
            case 6:
                return PlayerData.Instance.Unlock_Skin06;
            default:
                return PlayerData.Instance.Unlock_Skin01;
        }
    }
    public void SetDataSkinById(int value)
    {
        switch (Id)
        {
            case 1:
                PlayerData.Instance.Unlock_Skin01 = value;
                break;
            case 0:
                PlayerData.Instance.Unlock_Skin00 = value;
                break;
            case 2:
                PlayerData.Instance.Unlock_Skin02 = value; break;
            case 3:
                PlayerData.Instance.Unlock_Skin03 = value; break;
            case 4:
                PlayerData.Instance.Unlock_Skin04 = value; break;
            case 5:
                PlayerData.Instance.Unlock_Skin05 = value; break;
            case 6:
                PlayerData.Instance.Unlock_Skin06 = value; break;
            default:

                break;
        }
    }

}
