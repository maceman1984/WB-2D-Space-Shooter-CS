using UnityEngine;
using System;
using System.Collections;


public class FireScript:MonoBehaviour
{
    
    //public variables 
    public GameObject laser;
    public float fireFreq;
    public int laserType;
    
    //private variables
    float lastShot;
    float laserTimer;
    
    public void Update() 
    {
    if (Input.GetButtonDown ("Fire1") && (Time.time > lastShot + fireFreq) )
    	{
    	StartCoroutine(Fire());
    	}
    	laserTimer -=1 * Time.deltaTime;
    	if (laserTimer < 0) 
    	{
    		laserType = 0;
    	}
    }
    
    public IEnumerator Fire()
    {
    	lastShot = Time.time; 
    	if (laserType == 0) 
    	{
    	Instantiate (laser, transform.position, transform.rotation);
    	}
    	else if (laserType == 1) 
    	{
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, Quaternion.Euler(new Vector3(0.0f, -20.0f, 0.0f)));
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, transform.rotation);
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, Quaternion.Euler(new Vector3(0.0f, 20.0f, 0.0f)));
    	}
    	else if (laserType == 2) 
    	{
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, Quaternion.Euler(new Vector3(0.0f, -40.0f, 0.0f)));
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, Quaternion.Euler(new Vector3(0.0f, -20.0f, 0.0f)));
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, transform.rotation);
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, Quaternion.Euler(new Vector3(0.0f, 20.0f, 0.0f)));
    	yield return new WaitForSeconds (0.1f);
    	Instantiate (laser, transform.position, Quaternion.Euler(new Vector3(0.0f, 40.0f, 0.0f)));
    	}
    }
    
    public void PowerUpLaser()
    {
    	laserType += 1 ;
    	laserTimer = 3.0f;
    	laserType = Mathf.Clamp (laserType, 0, 2);
    }
}