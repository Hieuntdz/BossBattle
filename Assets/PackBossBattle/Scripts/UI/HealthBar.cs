﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
	public BossHealth bossHealth;
	public Slider slider;
	public void SetBossHealth(BossHealth _bosshealth){
		slider.maxValue = _bosshealth.health;
		this.bossHealth = _bosshealth;
	}
	// Update is called once per frame
	void Update()
    {
		if(bossHealth != null)
			slider.value = bossHealth.health;
    }
}
