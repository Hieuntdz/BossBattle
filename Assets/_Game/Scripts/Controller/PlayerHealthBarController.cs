using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class PlayerHealthBarController : MonoBehaviour
{
    public PlayerHealth PlayerHealth;
	public Slider slider;
    private bool isDoAnim = false;
    private void Awake() {
        PlayerHealth = MapController.Instance.Player;
        slider.maxValue = PlayerHealth.health;
    }
    private void Start() {
        
    }
    public void DoAnimHealth(){
		isDoAnim = true;
        slider.value = 0;
		DOTween.To(setter: value => {
            slider.value = value;
		}, startValue:0f, endValue:slider.maxValue, duration: .65f).SetEase(Ease.Linear).OnComplete(delegate{
            isDoAnim = false;
        });
	}
	// Update is called once per frame
	void Update()
    {
        if(Input.GetKeyDown(KeyCode.H)){
            slider.value += .1111f;
        }
        if(isDoAnim)
			return;
		if(PlayerHealth != null)
			slider.value = PlayerHealth.health;
    }
}
