using UnityEngine;
using System;


public class Enemy1Movement:MonoBehaviour
{
    
    //public variables 
    public Vector3 initPos; 
    public Vector2 enemyWiggle; 
    public float enemySpeed;
    
    
    //private variables
    
    public void Start() 
    {
    	initPos = transform.position; 
    }
    
    public void Update() 
    {
    	var tmp_cs1 = transform.position;
        tmp_cs1.x = initPos.x + Mathf.PingPong (Time.time * enemySpeed, enemyWiggle.x);
        tmp_cs1.z = initPos.z + Mathf.PingPong (Time.time * enemySpeed, enemyWiggle.y);
        transform.position = tmp_cs1;
    
    }
}