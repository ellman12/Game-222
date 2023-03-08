using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
	[SerializeField] private bool player;
	[SerializeField] private int maxHealth = 10;
	[SerializeField] private GameActionSequence deathSequence;
	private int currentHealth;
	private bool alive = true;
	
	public static Action<float> UpdateHealthBar = delegate {  };

	public bool IsAlive => alive;

	private void Start()
	{
		currentHealth = maxHealth;
	}

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log(currentHealth);
		UpdateHealth(-2);
	}

	private void OnCollisionEnter(Collision collision)
	{
		throw new NotImplementedException();
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
	}

	private void MegaDeath()
	{
		// if (!player)
			// UpdateScore()
		// Destroy(gameObject);
		deathSequence.Play();
	}
}