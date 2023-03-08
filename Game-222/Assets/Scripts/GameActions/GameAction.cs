using UnityEngine;

namespace GameActions
{
	public class GameAction : MonoBehaviour
	{
		public float delay;
		
		public virtual void Action() {}
		
		public virtual void DeAction() {}
		
		public virtual void ResetToDefaults() {}
	}
}