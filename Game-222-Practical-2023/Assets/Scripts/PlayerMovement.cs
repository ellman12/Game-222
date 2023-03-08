using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float speed = 10;
	[SerializeField] private Vector2 xClamp, yClamp;

	private PlayerInput pInput;
	private Vector3 direction, desiredPosition;

	private void Start()
	{
		pInput = new PlayerInput();
		pInput.Enable();
	}

	private void Update()
	{
		direction = pInput.Player.Movement.ReadValue<Vector2>();
		desiredPosition = transform.localPosition;
		direction.x = pInput.Player.Movement.ReadValue<Vector2>().x;
		direction.y = pInput.Player.Movement.ReadValue<Vector2>().y;
		direction.z = 0;
		desiredPosition += direction * (Time.deltaTime * speed);


		desiredPosition.x = Mathf.Clamp(desiredPosition.x, xClamp.x, xClamp.y);
		desiredPosition.y = Mathf.Clamp(desiredPosition.y, yClamp.x, yClamp.y);

		transform.localPosition = desiredPosition;
	}
}