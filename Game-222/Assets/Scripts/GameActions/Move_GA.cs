using UnityEngine;

namespace GameActions
{
	public class Move_GA : GameAction
	{
		public override void Action()
		{
			Vector3 tmp = transform.position;
			tmp.x += 2;
			transform.position = tmp;
		}
	}
}