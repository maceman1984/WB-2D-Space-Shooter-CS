using UnityEngine;
using System;


public class Shield:MonoBehaviour
{
    
    //Public Variables
    public int shieldStrength = 3;
    public GameObject shield;
    public GameObject explosion;
    public GameObject explosionSound;
    //Private Variables
    
    
    
    public void OnTriggerEnter(Collider col) 
    {
    	if (col.gameObject.tag == "EnemyLaser" && shieldStrength > 0)
    	{
    	Instantiate (explosion, transform.position, transform.rotation); 
    	Instantiate (explosionSound, transform.position, transform.rotation); 
    	
    	SubtractShield();
    	
    	Destroy (col.gameObject); 
    	}
    	else if (shieldStrength == 0)
    	{
    	Instantiate (explosion, transform.position, transform.rotation); 
    	Instantiate (explosionSound, transform.position, transform.rotation); 
    	
    	Destroy (col.gameObject); 
    	shield.SetActive (false);
    	}
    }
    
    public void SubtractShield()
    {
    	shieldStrength -= 1;
    }
}