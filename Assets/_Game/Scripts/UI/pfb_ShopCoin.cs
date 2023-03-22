using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pfb_ShopCoin : UIBehavior
{
    public Button btnClose;
    // Start is called before the first frame update
    void Start()
    {
        btnClose.onClick.AddListener(delegate{
            ActiveNormalPopup(false);
        });
    }

}
