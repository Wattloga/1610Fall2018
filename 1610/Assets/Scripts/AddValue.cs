using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class AddValue : ScriptableObject 
{
    public FloatData ValueObj;

	public void AddValueToObj (FloatData data)
	 {
	    ValueObj.Value += data.Value;	
	}
	
	 
		
	
}
