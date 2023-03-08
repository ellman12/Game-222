using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameActions
{
	public class GameActionTrigger : MonoBehaviour
	{
		[SerializeField] private List<GameAction> gameActions;
		private bool active;

		private void OnTriggerEnter(Collider other)
		{
			if (active) return;
			StartCoroutine(nameof(DelayActions));
		}

		private IEnumerator DelayActions()
		{
			active = true;
			foreach (GameAction item in gameActions)
			{
				yield return new WaitForSeconds(item.delay);
				item.Action();
			}

			active = false;
		}
	}
}