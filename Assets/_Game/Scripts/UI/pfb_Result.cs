using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class pfb_Result : UIBehavior
{
    public TextMeshProUGUI ResultText;
    public Button btnNextLevel, btnHome, btnRestart;
    void Start()
    {
        btnNextLevel.onClick.AddListener(NextLevel);
        btnHome.onClick.AddListener(Home);
        btnRestart.onClick.AddListener(Restart);
    }
    public void EndGame(string type){
        ActivePopup(true);
        if(type == "Win"){
            ResultText.text = "Win";
            btnNextLevel.gameObject.SetActive(true);
            btnHome.gameObject.SetActive(true);
            btnRestart.gameObject.SetActive(false);
        }else{
            ResultText.text = "Lose";
            btnNextLevel.gameObject.SetActive(false);
            btnHome.gameObject.SetActive(true);
            btnRestart.gameObject.SetActive(true);
        }
    }
    private void Restart(){
        MapController.Instance.OnCreateMap();
    }
    private void NextLevel(){
        PlayerData.Instance.CurrentLevel++;
        MapController.Instance.OnCreateMap();
    }
    private void Home(){
        MapController.Instance.gameObject.SetActive(false);
        UIManager.Instance.pfb_Home.ActivePopup();
    }
}
