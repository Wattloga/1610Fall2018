using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.PlayerConnection;

public class Instancing : MonoBehaviour
{

	public GameObject Instance;
	
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.X))
		{
			Instantiate(Instance, transform.position, transform.rotation);
			
		}
	}
	
}
