using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {
	
	public float acceleration;
		
	void Start () {
	
	}
	
	void Update () {
		
		if (Input.GetKey(KeyCode.W))
			rigidbody.AddForce(0f, 0f, acceleration, ForceMode.Acceleration);
		if (Input.GetKey(KeyCode.A))
			rigidbody.AddForce(-acceleration, 0f, 0f, ForceMode.Acceleration);
		if (Input.GetKey(KeyCode.S))
			rigidbody.AddForce(0f, 0f, -acceleration, ForceMode.Acceleration);
		if (Input.GetKey(KeyCode.D))
			rigidbody.AddForce(acceleration, 0f, 0f, ForceMode.Acceleration);
	
	}
}
