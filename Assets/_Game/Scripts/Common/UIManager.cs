using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoSingleton<UIManager>
{
    public pfb_Settings pfb_Settings;
    public pfb_Home pfb_Home;
    public pfb_Shop pfb_Shop;
    public pfb_GamePlay pfb_GamePlay;
    [SerializeField] private List<UIBehavior> listPopup = new List<UIBehavior>();
    public void Initialize()
    {
        pfb_Settings = InstantiateAndSetExistUIByName<pfb_Settings>("pfb_Settings");
        pfb_Home = InstantiateAndSetExistUIByName<pfb_Home>("pfb_Home");
        pfb_Shop = InstantiateAndSetExistUIByName<pfb_Shop>("pfb_Shop");
        pfb_GamePlay = InstantiateAndSetExistUIByName<pfb_GamePlay>("pfb_GamePlay");
        

        pfb_Settings.ActiveNormalPopup(false);
        pfb_Shop.ActiveNormalPopup(false);
        pfb_GamePlay.ActiveNormalPopup(false);
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
