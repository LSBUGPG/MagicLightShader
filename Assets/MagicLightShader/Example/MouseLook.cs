using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public Vector2 sensitivity = Vector2.one;
	Vector2 lastPosition;

	void Start()
	{
		lastPosition = Input.mousePosition;
	}

	void Update()
	{
		float yaw = (Input.mousePosition.x - lastPosition.x) * sensitivity.x;
		float pitch = (Input.mousePosition.y - lastPosition.y) * sensitivity.y;

		transform.Rotate(0.0f, yaw, 0.0f, Space.World);
		transform.Rotate(pitch, 0.0f, 0.0f, Space.Self);

		lastPosition = Input.mousePosition;
	}
}