using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.InputSystem;

public class PlayerAbilities : MonoBehaviour
{
	[SerializeField] private float fireRate = 0.1f;
	private PlayerInput pInput;

	public static Action PrimaryFire = delegate { };
	private bool bFireOn, bActive;

	private void Awake()
	{
		pInput = new PlayerInput();
	}

	private void OnEnable()
	{
		pInput.Enable();
		bActive = true;
		bFireOn = false;
		StartCoroutine(nameof(PerpetualFire));
		
		pInput.Player.Fire.performed += FireOn;
		pInput.Player.Fire.canceled += FireOff;
	}

	private void OnDisable()
	{
		pInput.Player.Fire.performed -= FireOn;
		pInput.Player.Fire.canceled -= FireOff;
		StopAllCoroutines();
	}

	private void FireOn(InputAction.CallbackContext c)
	{
		bFireOn = true;
	}

	private void FireOff(InputAction.CallbackContext c)
	{
		bFireOn = false;
	}

	IEnumerator PerpetualFire()
	{
		while (bActive)
		{
			yield return new WaitForSeconds(fireRate);
			if (bFireOn)
				PrimaryFire();
		}
	}
}