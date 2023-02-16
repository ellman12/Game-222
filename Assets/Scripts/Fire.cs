using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Fire : MonoBehaviour
{
	[SerializeField] private GameObject projectile;
	[SerializeField] private float fireRate = 0.1f;
	private bool fireOn, active;

	private PlayerInput playerInput;

	private void Start()
	{
		playerInput = new PlayerInput();
		playerInput.Enable();
		active = true;
		StartCoroutine(PerpetualFiring());
		playerInput.Player.Fire.performed += FireOn;
		playerInput.Player.Fire.canceled += FireOff;
	}

	private void OnDisable()
	{
		playerInput.Disable();
		playerInput.Player.Fire.performed -= FireOn;
		playerInput.Player.Fire.canceled -= FireOff;
	}

	private void FireOn(InputAction.CallbackContext _)
	{
		fireOn = true;
	}

	private void FireOff(InputAction.CallbackContext _)
	{
		fireOn = false;
	}

	private void FireShot()
	{
		Instantiate(projectile, transform.position, Quaternion.identity);
	}

	private IEnumerator PerpetualFiring()
	{
		while (active)
		{
			yield return new WaitForEndOfFrame();
			if (fireOn)
			{
				yield return new WaitForSeconds(fireRate);
				FireShot();
			}
		}
	}
}