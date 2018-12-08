using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ValueChange: ScriptableObject
{

	public FloatData Data;

	public void AddValue(FloatData data)
	{
		data.Value += Data.Value;
	}

	public void SubtractValue(FloatData data)
	{
		data.Value -= Data.Value;
	}
}

