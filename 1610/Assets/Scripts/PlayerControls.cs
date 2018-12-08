using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

	//This is a reference to the Rigidbody component
	public Rigidbody rb;


	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	
	//We marked this as "Fixed" Update because we 
	// are using it to apply to the physics.
     void FixedUpdate()
	{
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d") )
		{
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		
		if (Input.GetKey("a") )
		{
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		
	}
}
