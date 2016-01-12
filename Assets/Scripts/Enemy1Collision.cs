using UnityEngine;
using System;
using System.Collections;


public class Enemy1Collision:MonoBehaviour
{
    
    //public variables 
    public int enemyLives 			= 2;
    public GameObject explosion;
    public GameObject explosionSound;
    public GameObject sceneMan; 			
    
    //private variables
    
    public IEnumerator OnTriggerEnter(Collider col) 
    {
    	if (col.gameObject.tag == "Laser" && enemyLives > 0)
    	{
    	Instantiate (explosion, transform.position, transform.rotation); 
    	Instantiate (explosionSound, transform.position, transform.rotation); 
    	
    	SubtractLife();
    	collider.enabled = false;
    	
    	Destroy (col.gameObject); 
    	
    	yield return new WaitForSeconds (.2f);
    	collider.enabled = true;
    	}
    	else if (enemyLives == 0)
    	{
    	Instantiate (explosion, transform.position, transform.rotation); 
    	Instantiate (explosionSound, transform.position, transform.rotation); 
    	
    	sceneMan.transform.GetComponent<PlayerMovement>().AddScore();  
    
    	Destroy (col.gameObject); 
    	Destroy (gameObject); 
    	}
    }
    
    public void SubtractLife()
    {
    	enemyLives -= 1;
    }

}