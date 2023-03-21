using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pfb_GamePlay : UIBehavior
{
    public HealthBar HealthBar;
    public Button btnBack;
    private void Start() {
        btnBack.onClick.AddListener(OnClickBack);
    }

    private void OnClickBack(){
        MapController.Instance.gameObject.SetActive(false);
        UIManager.Instance.pfb_Home.ActivePopup(true);
    }
}
