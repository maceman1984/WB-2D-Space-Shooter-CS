using UnityEngine;
using System;


public class PowerUp:MonoBehaviour
{
    
    //public variables 
    public float powerUpSpeed; 
    
    //private variables
    
    
    
    public void Update() 
    {
    	transform.Translate (0.0f, 0.0f, powerUpSpeed * Time.deltaTime);
    	
    	if ((transform.position.z > 4.7f) || (transform.position.z < -4.15f))
    		{
    		Destroy (gameObject);
    		}
    }
}