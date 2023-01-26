using System;
using System.Collections;
using UnityEngine;

public class Projectile : MonoBehaviour
{
	[SerializeField] private Vector3 direction = Vector3.up;
	[SerializeField] private float speed = 10;

	private void Start()
	{
		StartCoroutine(nameof(WaitToDie));
	}

	private void Update()
	{
		transform.position += direction * (speed * Time.deltaTime);
	}

	private IEnumerator WaitToDie()
	{
		yield return new WaitForSeconds(2);
		Destroy(gameObject);
	}
}