using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    // public pfb_GamePlay pfb_GamePlay;
    // public pfb_Result pfb_Result;
    // public pfb_Shop pfb_Shop;
    // public pfb_Settings pfb_Settings;
    // public pfb_GetGift pfb_GetGift;
    // public pfb_PopupText pfb_PopupText;
    [SerializeField] private List<UIBehavior> listPopup = new List<UIBehavior>();
    public void Initialize()
    {
        // pfb_GamePlay = InstantiateAndSetExistUIByName<pfb_GamePlay>("pfb_GamePlay");
        // pfb_Result = InstantiateAndSetExistUIByName<pfb_Result>("pfb_Result");
        // pfb_Shop = InstantiateAndSetExistUIByName<pfb_Shop>("pfb_Shop");
        // pfb_Settings = InstantiateAndSetExistUIByName<pfb_Settings>("pfb_Settings");
        // pfb_GetGift = InstantiateAndSetExistUIByName<pfb_GetGift>("pfb_GetGift"); 
        // pfb_PopupText = InstantiateAndSetExistUIByName<pfb_PopupText>("pfb_PopupText"); 
        
        // pfb_Shop.CatZone.Init();
        // pfb_Shop.CageZone.Init();
        // pfb_Shop.BackgroundZone.Init();
    }
    private T InstantiateAndSetExistUIByName<T>(string Path) where T : UIBehavior
    {
        var obj = Instantiate<T>(Resources.Load<T>(Path));
        DontDestroyOnLoad(obj);
        listPopup.Add(obj);
        return obj;
    }
    public void DeactivateAllPopup()
    {
        listPopup.ForEach(x => x.gameObject.SetActive(false));
    }
}
