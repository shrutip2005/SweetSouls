using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//UnityEngineInternal.Input.NativeInputUpdateType,intptr; 

public class jumpTesting1 : MonoBehaviour
{
	private Rigidbody2D sphereRigidbody;
	public int jumpyo;

	private void Awake()
	{
		sphereRigidbody=GetComponent<Rigidbody2D>();
	}

   public void Jump(InputAction.CallbackContext context)
   {	
	   if(context.performed)
	   {
		   if(sphereRigidbody.velocity.y == 0)
		   {
				Debug.Log("Jump!!! "+ context.phase);
				sphereRigidbody.AddForce(Vector3.up * jumpyo,ForceMode2D.Impulse);
		   }
	   }
	   
   }

   public void Jump_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        var jumpOverTime = context.duration;
        if (jumpOverTime > 1) return;
        if(jumpOverTime > .2f)
        sphereRigidbody.AddForce(Vector3.up * (5f * (float) jumpOverTime), ForceMode2D.Impulse);
	}
}