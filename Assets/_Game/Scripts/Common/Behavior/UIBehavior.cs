using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public abstract class UIBehavior : MonoBehaviour
{
    protected virtual void Awake()
    {
        SetUpCamera();
    }
    protected virtual void OnEnable(){
        UpdateUI();
    }
    protected virtual void SetUpCamera(){
        GetComponent<Canvas>().worldCamera = Camera.main;
    }
    public virtual void ActivePopup(bool active = true){
        UIManager.Instance.DeactivateAllPopup();
        gameObject.SetActive(active);
    }
    public virtual void ActiveNormalPopup(bool active = true){
        gameObject.SetActive(active);
    }
    protected virtual void UpdateUI(){

    }
}