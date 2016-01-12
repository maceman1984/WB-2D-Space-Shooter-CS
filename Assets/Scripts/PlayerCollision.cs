using UnityEngine;
using System;
using System.Collections;


public class PlayerCollision:MonoBehaviour
{
    
    //public variables 
    public int lives 			= 3;
    //var shield 			: GameObject;
    public GameObject explosion;
    public GameObject explosionSound;
    
    //private variables
    public void Update() 
    {
    	if(lives <= 0)
    	{
    	Application.LoadLevel ("SceneLose");
    	lives = 3;
    	}
    }
    
    public IEnumerator OnTriggerEnter(Collider col) 
    {
    	if (col.gameObject.tag == "EnemyLaser" && lives > 0)
    	{
    	Instantiate (explosion, transform.position, transform.rotation); 
    	Instantiate (explosionSound, transform.position, transform.rotation); 
    	
    	SubtractLife();
    	collider.enabled = false;
    	
    	Destroy (col.gameObject); 
    	
    	yield return new WaitForSeconds (.3f);
    	collider.enabled = true;
    	}
    	else if (lives == 0)
    	{
    	Instantiate (explosion, transform.position, transform.rotation); 
    	Instantiate (explosionSound, transform.position, transform.rotation); 
    	
    	Destroy (col.gameObject); 
    	Destroy (gameObject); 
    
    	}
    }
    
    public void SubtractLife()
    {
    	lives -= 1;
    }
}