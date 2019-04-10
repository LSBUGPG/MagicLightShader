using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float speed = 1.0f;
	void Update()
	{
		Vector3 direction = 
			Vector3.right * Input.GetAxis("Horizontal") + 
			Vector3.forward * Input.GetAxis("Vertical");

		transform.Translate(direction * Time.deltaTime * speed);
	}
}
