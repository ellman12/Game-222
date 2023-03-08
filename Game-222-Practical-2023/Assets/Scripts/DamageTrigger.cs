using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTrigger : MonoBehaviour
{
	[SerializeField] private int damageAmount = -1;
	[SerializeField] private bool bDestroyOnHit;

	private void OnTriggerEnter(Collider other)
	{
		if (other.TryGetComponent(out HealthSystem hSystem))
		{
			hSystem.UpdateHealth(damageAmount);
			if (bDestroyOnHit)
			{
				Destroy(gameObject);
			}
		}
	}
}