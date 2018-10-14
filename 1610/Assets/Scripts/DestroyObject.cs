﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	
	IEnumerator Start () {
		yield return new WaitForSeconds(2);
		Destroy(gameObject);
	
	}

    private void OnCollisionEnter(Collision other)
	{
		Destroy(gameObject);
		Destroy(other.gameObject);
	}
}
