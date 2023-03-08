using System;
using System.Collections;
using UnityEngine;

namespace GameActions
{
	public class SpeedBoost_GA : GameAction
	{
		[SerializeField] private float speedBoostDuration = 2;
		
		public static Action SpeedBoostOn = delegate {  };
		public static Action SpeedBoostOff = delegate {  };

		private bool active;

		public override void Action()
		{
			if (active) return;
			SpeedBoostOn();
			StartCoroutine(nameof(SpeedBoostOffDelay));
		}

		private IEnumerator SpeedBoostOffDelay()
		{
			active = true;
			yield return new WaitForSeconds(speedBoostDuration);
			SpeedBoostOff();
			active = false;
		}
	}
}