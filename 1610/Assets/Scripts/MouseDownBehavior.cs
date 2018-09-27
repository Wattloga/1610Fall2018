using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseDownBehavior : MonoBehaviour
{
 public UnityEvent Event;
 private void OnMouseDown()
 {
   Event.Invoke();
 }
   
}
		

	
