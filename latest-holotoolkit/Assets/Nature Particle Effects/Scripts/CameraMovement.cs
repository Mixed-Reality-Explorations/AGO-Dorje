using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float rotationSpeed;

	private Vector3 rotation;

	void FixedUpdate () {

		if (Input.GetKey (KeyCode.A)) {
			rotation.y += rotationSpeed * Time.deltaTime;
			transform.rotation = Quaternion.Euler (rotation);
		} else if (Input.GetKey (KeyCode.D)) {
			rotation.y -= rotationSpeed * Time.deltaTime;
			transform.rotation = Quaternion.Euler (rotation);
		}

	}
}
