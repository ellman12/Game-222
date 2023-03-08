using GameActions;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Vector3 direction;
	private bool speedBoost;
	[SerializeField] private float normalSpeed, fastSpeed, currentSpeed;
	private PlayerInput playerInput;

	private void Start()
	{
		SpeedBoost_GA.SpeedBoostOn += SpeedBoostOn;
		SpeedBoost_GA.SpeedBoostOff += SpeedBoostOff;
		playerInput = new PlayerInput();
		playerInput.Enable();
		currentSpeed = normalSpeed;

		playerInput.Player.Faster.performed += _ => currentSpeed = fastSpeed;
		playerInput.Player.Faster.canceled += _ => currentSpeed = normalSpeed;
	}

	private void OnDisable()
	{
		SpeedBoost_GA.SpeedBoostOn -= SpeedBoostOn;
		SpeedBoost_GA.SpeedBoostOff -= SpeedBoostOff;
		playerInput.Disable();
	}

	private void SpeedBoostOn() => speedBoost = true;

	private void SpeedBoostOff() => speedBoost = false;

	private void Update()
	{
		direction.x = playerInput.Player.Movement.ReadValue<Vector2>().x;
		direction.y = playerInput.Player.Movement.ReadValue<Vector2>().y;
		
		if (speedBoost)
			transform.position += direction * (fastSpeed * Time.deltaTime);
		else
			transform.position += direction * (normalSpeed * Time.deltaTime);
	}
}