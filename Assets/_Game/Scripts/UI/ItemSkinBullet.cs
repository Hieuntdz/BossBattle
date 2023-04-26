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

                CoinIcon.SetActive(true);
                CoinTxt.gameObject.SetActive(true);

            if(Id == 1 || Id == 7 || Id == 8){
                CoinIcon.SetActive(false);
                CoinTxt.gameObject.SetActive(false);
            }
            if(Id >= 9 || Id <= 17){
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
                // IAPManager.Instance.Purchase(Facade.m_skin01_pack, () => Time.timeScale = 1f );
                UIManager.Instance.pfb_Shop.EnablePopupSkin01(true);
            else if (Id == 7)
                UIManager.Instance.pfb_Shop.EnablePopupSkin07(true);
            else if (Id == 8)
                UIManager.Instance.pfb_Shop.EnablePopupSkin08(true);
            else if (Id >= 9 && Id <= 17)
                UIManager.Instance.pfb_Shop.EnablePopupSkin(true, Id);
            else
                OnBuy();
        }
    }
    public void OnBuy(){
        if(PlayerData.Instance.Coin < this.coin){
            //deo du tien
        }else{  
            PlayerData.Instance.Coin -= this.coin;
            SetDataSkinById(1);
            PlayerData.Instance.Skin_Equipped = Id;
            UIManager.Instance.pfb_Home.UpdateCoin();
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
            case 7:
                return PlayerData.Instance.Unlock_Skin07;
            case 8:
                return PlayerData.Instance.Unlock_Skin08;
            case 9:
                return PlayerData.Instance.Unlock_Skin09;
            case 10:
                return PlayerData.Instance.Unlock_Skin10;
            case 11:
                return PlayerData.Instance.Unlock_Skin11;
            case 12:
                return PlayerData.Instance.Unlock_Skin12;
            case 13:
                return PlayerData.Instance.Unlock_Skin13;
            case 14:
                return PlayerData.Instance.Unlock_Skin14;
            case 15:
                return PlayerData.Instance.Unlock_Skin15;
            case 16:
                return PlayerData.Instance.Unlock_Skin16;
            case 17:
                return PlayerData.Instance.Unlock_Skin17;
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
            case 7:
                PlayerData.Instance.Unlock_Skin07 = value; break;
            case 8:
                PlayerData.Instance.Unlock_Skin08 = value; break;
            case 9:
                PlayerData.Instance.Unlock_Skin09 = value; break;
            case 10:
                PlayerData.Instance.Unlock_Skin10 = value; break;
            case 11:
                PlayerData.Instance.Unlock_Skin11 = value; break;
            case 12:
                PlayerData.Instance.Unlock_Skin12 = value; break;
            case 13:
                PlayerData.Instance.Unlock_Skin13 = value; break;
            case 14:
                PlayerData.Instance.Unlock_Skin14 = value; break;
            case 15:
                PlayerData.Instance.Unlock_Skin15 = value; break;
            case 16:
                PlayerData.Instance.Unlock_Skin16 = value; break;
            case 17:
                PlayerData.Instance.Unlock_Skin17 = value; break;
            default:

                break;
        }
    }

}
