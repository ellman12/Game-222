using UnityEngine;

public class CubeColorChanger : MonoBehaviour
{
	[SerializeField] private Vector2 direction;
	[SerializeField] private GameObject topLeft, middleLeft, bottomLeft, bottomCenter, bottomRight, middleRight, topRight, topCenter, middleCenter;
	private CubeColorChangerInput input;

	private void Start()
	{
		input = new CubeColorChangerInput();
		input.Enable();

		input.Player.Direction.performed += _ =>
		{
			middleCenter.GetComponent<MeshRenderer>().material.color = Color.red;
			topLeft.GetComponent<MeshRenderer>().material.color = Color.white;
			middleLeft.GetComponent<MeshRenderer>().material.color = Color.white;
			bottomLeft.GetComponent<MeshRenderer>().material.color = Color.white;
			bottomCenter.GetComponent<MeshRenderer>().material.color = Color.white;
			bottomRight.GetComponent<MeshRenderer>().material.color = Color.white;
			middleRight.GetComponent<MeshRenderer>().material.color = Color.white;
			topRight.GetComponent<MeshRenderer>().material.color = Color.white;
			topCenter.GetComponent<MeshRenderer>().material.color = Color.white;
		};
	}

	private void Update()
	{
		direction = input.Player.Direction.ReadValue<Vector2>();
		switch (direction.x, direction.y)
		{
			case (-1, 1):
				topLeft.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			case (-1, 0):
				middleLeft.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			case (-1, -1):
				bottomLeft.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			case (0, -1):
				bottomCenter.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			case (1, -1):
				bottomRight.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			case (1, 0):
				middleRight.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			case (1, 1):
				topRight.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			case (0, 1):
				topCenter.GetComponent<MeshRenderer>().material.color = Color.green;
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;

			default:
				middleCenter.GetComponent<MeshRenderer>().material.color = Color.red;
				topLeft.GetComponent<MeshRenderer>().material.color = Color.white;
				middleLeft.GetComponent<MeshRenderer>().material.color = Color.white;
				bottomLeft.GetComponent<MeshRenderer>().material.color = Color.white;
				bottomCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				bottomRight.GetComponent<MeshRenderer>().material.color = Color.white;
				middleRight.GetComponent<MeshRenderer>().material.color = Color.white;
				topRight.GetComponent<MeshRenderer>().material.color = Color.white;
				topCenter.GetComponent<MeshRenderer>().material.color = Color.white;
				break;
		}
	}
}