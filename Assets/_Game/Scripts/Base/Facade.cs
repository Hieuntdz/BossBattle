using System.Linq;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.Purchasing;

public class Facade : MonoSingleton<Facade>
{
    #region PRODUCT ID
    public static string m_skin01_7day = "m_skin01_7day";
    public static string m_skin01_1month = "m_skin01_1month";
    public static string m_skin01_1year = "m_skin01_1year";

    public static string m_skin02_7days_1 = "m_skin02_7days_1";
    public static string m_skin02_7days_2 = "m_skin02_7days_2";
    public static string m_skin02_7days_3 = "m_skin02_7days_3";
    public static string m_skin02_7days_4 = "m_skin02_7days_4";
    public static string m_skin02_7days_5 = "m_skin02_7days_5";
    public static string m_skin02_7days_6 = "m_skin02_7days_6";

    public static string m_skin01_4week = "m_skin01_4week";
    public static string m_skin01_3month = "m_skin01_3month";
    public static string m_skin01_6month = "m_skin01_6month";



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
    public PlayerData PlayerData;
    public GameManager GameManager;
    public MapController MapController;
    protected override void Awake()
    {
        Application.targetFrameRate = 60;
        base.Awake();
        ClearData();
        PlayerData = new GameObject("PlayerData").AddComponent<PlayerData>();

        IAPManager.Instance.OnInitialized += (success) =>
        {
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin01_7day))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin01 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin01 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }

            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin01_1month))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin07 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin07 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin01_1year))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin08 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin08 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }

            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin02_7days_1))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin09 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin09 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }

            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin02_7days_2))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin10 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin10 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin02_7days_3))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin11 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin11 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin02_7days_4))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin12 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin12 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin02_7days_5))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin13 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin13 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin02_7days_6))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin14 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin14 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin01_4week))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin15 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin15 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin01_3month))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin16 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin16 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
            if (success && IAPManager.Instance.IsNonConsumablePurchased(m_skin01_6month))
            {
                //product was purchased in a previous session
                PlayerData.Instance.Unlock_Skin17 = 1;
            }
            else
            {
                PlayerData.Instance.Unlock_Skin17 = 0;
                if (PlayerData.Instance.Skin_Equipped == 1)
                    PlayerData.Instance.Skin_Equipped = 0;
            }
        };
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
        IAPManager.Instance.Initialize(
        new ProductDefinition(m_skin01_7day, ProductType.Subscription),
        new ProductDefinition(m_skin01_1month, ProductType.Subscription),
        new ProductDefinition(m_skin01_1year, ProductType.Subscription),

        new ProductDefinition(m_skin02_7days_1, ProductType.Subscription),
        new ProductDefinition(m_skin02_7days_2, ProductType.Subscription),
        new ProductDefinition(m_skin02_7days_3, ProductType.Subscription),
        new ProductDefinition(m_skin02_7days_4, ProductType.Subscription),
        new ProductDefinition(m_skin02_7days_5, ProductType.Subscription),
        new ProductDefinition(m_skin02_7days_6, ProductType.Subscription),
        new ProductDefinition(m_skin01_4week, ProductType.Subscription),
        new ProductDefinition(m_skin01_3month, ProductType.Subscription),
        new ProductDefinition(m_skin01_6month, ProductType.Subscription),

        new ProductDefinition(m_coin_100, ProductType.Consumable),
        new ProductDefinition(m_coin_300, ProductType.Consumable),
        new ProductDefinition(m_coin_500, ProductType.Consumable),
        new ProductDefinition(m_coin_800, ProductType.Consumable),
        new ProductDefinition(m_coin_1000, ProductType.Consumable),
        new ProductDefinition(m_coin_2000, ProductType.Consumable),
        new ProductDefinition(m_coin_2500, ProductType.Consumable),
        new ProductDefinition(m_coin_5000, ProductType.Consumable),
        new ProductDefinition(m_coin_8000, ProductType.Consumable),
        new ProductDefinition(m_coin_10000, ProductType.Consumable)
        );
    }
    public void OnPurchasedCoin(int coin)
    {
        PlayerData.Instance.Coin += coin;
        UIManager.Instance.pfb_Home.UpdateCoin();
    }
    void Start()
    {
        Initialize();
        //Set bg
    }
    public void Vibrate()
    {
        if (PlayerData.VibrateState != 1)
            return;
        Taptic.Vibrate();
    }
    private void Initialize()
    {
        Instantiate(Utils.ResourcesLoad<GameObject>("CreateController"));
        new GameObject("UIManager").AddComponent<UIManager>();
        UIManager.Instance.Initialize();
        GameManager = Instantiate<GameManager>(Utils.ResourcesLoad<GameManager>("GameManager"));
        DontDestroyOnLoad(GameManager);
    }
    private void ClearData()
    {
        // if (!PlayerPrefs.HasKey("BundleVersion"))
        // {
        //     string path = DataController.GetFilePath(Config.key_skin_cat);
        //     string path2 = DataController.GetFilePath(Config.key_skin_cage);
        //     string path3 = DataController.GetFilePath(Config.key_skin_background);
        //     Debug.LogError("paths: " + path);
        //     if (File.Exists(path))
        //         File.Delete(path);
        //     if (File.Exists(path2))
        //         File.Delete(path2);
        //     if (File.Exists(path3))
        //         File.Delete(path3);
        // }
    }

}
