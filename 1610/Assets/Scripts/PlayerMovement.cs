using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

	public Rigidbody rb;
	public float movingForce = 1000f;
	public float sidewaysForce = 1000f;
	
	// Update is called once per frame
	void FixedUpdate () {
		
		rb.AddForce(0, 0, movingForce * Time.deltaTime);


		if (Input.GetKey("f") )
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
		}
		
		
		if (Input.GetKey("b") )
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
		}
	}
	
}
