using UnityEngine;

public class HealthSystem : MonoBehaviour
{
	[SerializeField] private int maxHealth = 10;
	private int currentHealth;
	private bool alive = true;

	public bool IsAlive => alive;

	private void Start()
	{
		currentHealth = maxHealth;
	}

	public void UpdateHealth(int amount)
	{
		currentHealth += amount;
		currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);
		if (currentHealth == 0)
			alive = false;
		
		Debug.Log(currentHealth);
	}

	private void MegaDeath()
	{
		Destroy(gameObject);
	}
}