using UnityEngine;
using System;


public class Enemy1Fire:MonoBehaviour
{
    
    //public variables 
    public GameObject enemyLaser;
    public float fireFreq;
    
    //private variables
    float lastShot;
    
    public void Update()
    {
    if (Time.time > lastShot + fireFreq)
    	Fire ();
    }
    
    public void Fire()
    {
    	lastShot = Time.time;
    	Instantiate (enemyLaser, transform.position, transform.rotation);
    }
}