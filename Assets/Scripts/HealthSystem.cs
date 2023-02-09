using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
	[SerializeField] private bool player;
	[SerializeField] private int maxHealth = 10;
	private int currentHealth;
	private bool alive = true;
	
	public static Action<float> UpdateHealthBar = delegate {  };

	public bool IsAlive => alive;

	private void Start()
	{
		currentHealth = maxHealth;
	}

	public void UpdateHealth(int amount)
	{
		currentHealth += amount;
		currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
		
		//Talk to HealthBar
		if (player)
			UpdateHealthBar(currentHealth / (maxHealth * 1f));
		
		if (currentHealth == 0)
			MegaDeath();
		
		Debug.Log(currentHealth);
	}

	private void MegaDeath()
	{
		Destroy(gameObject);
	}
}