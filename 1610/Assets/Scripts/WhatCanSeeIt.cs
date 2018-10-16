using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhatCanSeeIt: ScriptableObject
{

	private float health;
	protected float PowerLevel;
	public float EneryLevel;

	private void AddHealth()
	{
		health += 100;
	}

	protected void AddPower()
	{
		AddHealth();
	}

	public void AddEnergy()
	{
		
	}
	
}

public class ICanSeeIt: MonoBehaviour
{
	private WhatCanSeeIt newObject;

	private void Start()
	{
		newObject.EneryLevel = 100;
		newObject.AddEnergy();
	}
}

public class Child : WhatCanSeeIt
{
	void CallThings()
	{
		PowerLevel = 200;
		EneryLevel = 300;
		AddPower();
		AddEnergy();
	}
}