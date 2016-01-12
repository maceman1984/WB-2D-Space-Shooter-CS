using UnityEngine;
using System;


public class LaserMovement:MonoBehaviour
{
    
    //public variables 
    public float laserSpeed; 
    //private variables
    
    
    
    public void Update() 
    {
    	transform.Translate (0.0f, 0.0f, laserSpeed * Time.deltaTime);
    	
    	if ((transform.position.z > 4.7f) || (transform.position.z < -4.15f))
    		{
    		Destroy (gameObject);
    		}
    }
}