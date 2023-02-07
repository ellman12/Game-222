using UnityEngine;

public class FlexibleHP : MonoBehaviour
{
	[SerializeField] private int flexHealth = 5;

	private void OnTriggerEnter(Collider other)
	{
		if (other.TryGetComponent(out HealthSystem healthSystem))
		{
			healthSystem.UpdateHealth(flexHealth);
		}
	}
}