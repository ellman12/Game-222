using UnityEngine;

namespace GameActions
{
	public class DecreaseSize_GA : GameAction
	{
		public override void Action()
		{
			transform.localScale /= 2;
		}
	}
}