using UnityEngine;
using System;


public class PlayerMovement:MonoBehaviour
{
    
    public KeyCode shieldKeyInput; 
    public GameObject shield;
    public float playerSpeed;
    public static int score	= 0;
    
    
    //private variables
    
    public void Awake() 
    {
    	shield.SetActive (false);
    	ResetVaribales();
    }
    
    public void Update() 
    {
    	transform.Translate (Input.GetAxisRaw ("Horizontal") * Time.deltaTime * playerSpeed, 0.0f, Input.GetAxisRaw ("Vertical")* Time.deltaTime * playerSpeed);
    
    	var tmp_cs1 = transform.position;
        tmp_cs1.x = Mathf.Clamp (transform.position.x, -4.64f, 4.64f);
        tmp_cs1.z = Mathf.Clamp (transform.position.z, -3.26f, 3.2f);
        transform.position = tmp_cs1; 
    
    		//Create shield
    		if (Input.GetKeyDown(shieldKeyInput))
    		{
    		shield.SetActive (true);
    		}
    	if(score == 9)
    	{
    	Application.LoadLevel ("ScreenWin");
    	}
    }
    
    public void AddScore() 
    {
    	//add score varable + 1
    	score +=1;
    	print("score:" + score);
    }
    
    public void ResetVaribales()
    {
    score = 0;
    }
}