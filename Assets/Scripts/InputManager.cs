using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
	private PlayerInput playerInput;

	private void Start()
	{
		//Initialization
		playerInput = new PlayerInput();
		playerInput.Enable();

		//Subscribing
		playerInput.Player.ButtonTest.performed += Pressed;
	}

	private void OnDisable()
	{
		playerInput.Player.ButtonTest.performed -= Pressed;
	}

	private void Pressed(InputAction.CallbackContext monkey)
	{
		Debug.Log("Pressed!");
		transform.position += new Vector3(0, 1, 0);
	}
}
