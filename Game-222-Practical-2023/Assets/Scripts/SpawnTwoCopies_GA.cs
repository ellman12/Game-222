using UnityEngine;

public class SpawnTwoCopies_GA : GameAction
{
	[SerializeField] private GameObject prefab;

	public override void Action()
	{
		Instantiate(prefab, transform.position + Vector3.left * 2, Quaternion.identity);
		Instantiate(prefab, transform.position + Vector3.right * 2, Quaternion.identity);
	}
}