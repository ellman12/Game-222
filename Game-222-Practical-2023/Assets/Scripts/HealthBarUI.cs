using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBarUI : MonoBehaviour
{
	[SerializeField] private Image healthBar;
	[SerializeField] private TextMeshProUGUI healthText;

	private void OnEnable()
	{
		UpdateHealthBar(1);
		HealthSystem.UpdateHealthBar += UpdateHealthBar;
	}

	private void OnDisable() => HealthSystem.UpdateHealthBar -= UpdateHealthBar;

	private void UpdateHealthBar(float amount)
	{
		Debug.Log(healthBar.fillAmount);
		healthBar.fillAmount = amount;
		healthText.text = (amount * 100).ToString();
	}
}