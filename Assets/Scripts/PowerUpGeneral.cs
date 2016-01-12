using UnityEngine;
using System;


public class PowerUpGeneral:MonoBehaviour
{
    
    //public variables 
    public GameObject powerUpSound; 
    public float powerUpSpeed; 
    //private variables
    
    public void Update() 
    {
    	transform.Translate (0.0f, 0.0f, powerUpSpeed * Time.deltaTime);
    	
    	if (transform.position.z < -4.15f)
    		{
    		ResetObject ();
    		}
    }
    
    public void OnTriggerEnter(Collider col) 
    {
    	if (col.gameObject.tag == "Player") 
    	{
    	GameObject.Find ("Player").GetComponent<FireScript>().PowerUpLaser();
    	Instantiate (powerUpSound, transform.position, transform.rotation);
    	ResetObject ();
    	}
    }
    
    public void ResetObject()
    {
    		//Reset the position of the enemy
    		var tmp_cs1 = transform.position;
            tmp_cs1.z = (float)UnityEngine.Random.Range (20, 40);
            tmp_cs1.x = UnityEngine.Random.Range (-4.26f, 4.15f);
            transform.position = tmp_cs1;
    }
}