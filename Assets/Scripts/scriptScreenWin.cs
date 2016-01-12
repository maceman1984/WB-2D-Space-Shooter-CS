using UnityEngine;
using System;


public class scriptScreenWin:MonoBehaviour
{
    //Win Script
    
    //Public Variables
    public string winQuote = "You Win!";
    
    //Private Variables
    
    public void OnGUI() 
    {
    	GUI.BeginGroup (new Rect((float)(Screen.width / 2 - 100), (float)(Screen.height / 2 - 100),200.0f,100.0f));
    	
    	GUI.Box (new Rect(0.0f,0.0f,200.0f,100.0f), winQuote);
    	
    	if(GUI.Button (new Rect(60.0f,60.0f,80.0f,30.0f), "Main Menu"))
    	{
    		Application.LoadLevel ("ScreenStartMenu");
    	}
    	GUI.EndGroup();
    }
}