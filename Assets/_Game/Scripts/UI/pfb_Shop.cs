using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pfb_Shop : UIBehavior
{
    public List<ItemSkinBullet> ListSkinBullet = new List<ItemSkinBullet>();
    public Button btnClose;
    public List<Sprite> ListSpriteBullet = new List<Sprite>();
    private void Start() {
        btnClose.onClick.AddListener(OnClose);
    }
    protected override void UpdateUI()
    {
        base.UpdateUI();
        UpdateAllItemSkinBullet();
    }
    public void UpdateAllItemSkinBullet(){
        ListSkinBullet.ForEach(x => x.updateUI());
    }

    public void OnClose(){
        ActiveNormalPopup(false);
    }

    public Sprite GetSkinBullet(int id){
        return ListSpriteBullet[id];
    }
}
