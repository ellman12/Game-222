using UnityEngine;

namespace GameActions
{
	[RequireComponent(typeof(MeshRenderer))]
	public class IncrementColor_GA : GameAction
	{
		private MeshRenderer meshRenderer;

		private void Start()
		{
			meshRenderer = GetComponent<MeshRenderer>();
		}

		public override void Action()
		{
			Vector4 tempColor = meshRenderer.material.color;
			tempColor.x += 30f;
			meshRenderer.material.color = tempColor;
		}
	}
}