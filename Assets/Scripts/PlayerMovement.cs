using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Vector3 direction;
	[SerializeField] private float normalSpeed, fastSpeed, currentSpeed;
	private PlayerInput playerInput;

	private void Start()
	{
		playerInput = new PlayerInput();
		playerInput.Enable();
		currentSpeed = normalSpeed;
		
		playerInput.Player.Faster.performed += _ => currentSpeed = fastSpeed;
		playerInput.Player.Faster.canceled += _ => currentSpeed = normalSpeed;
	}

	private void OnDisable()
	{
		playerInput.Disable();
	}

	private void Update()
	{
		direction.x = playerInput.Player.Movement.ReadValue<Vector2>().x;
		direction.y = playerInput.Player.Movement.ReadValue<Vector2>().y;
		transform.position += direction * (currentSpeed * Time.deltaTime);
	}
}