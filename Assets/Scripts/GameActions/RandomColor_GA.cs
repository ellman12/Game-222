using UnityEngine;

namespace GameActions
{
	[RequireComponent(typeof(MeshRenderer))]
	public class RandomColor_GA : GameAction
	{
		private MeshRenderer meshRenderer;

		private void Start()
		{
			meshRenderer = GetComponent<MeshRenderer>();
		}

		public override void Action()
		{
			Color c = new(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
			Debug.Log(c);
			meshRenderer.material.color = c;
		}
	}
}