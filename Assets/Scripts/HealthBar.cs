using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class HealthBar : MonoBehaviour
{
	private Image healthBar;

	private void Start()
	{
		healthBar = GetComponent<Image>();
	}

	private void UpdateHealthBar(float slider)
	{
		healthBar.fillAmount = slider;
	}

	private void OnEnable()
	{
		HealthSystem.UpdateHealthBar += UpdateHealthBar;
	}

	private void OnDisable()
	{
		HealthSystem.UpdateHealthBar -= UpdateHealthBar;
	}
}