using UnityEngine;
using System;


public class scriptScreenMainMenu:MonoBehaviour
{
    //Main Menu Script
    
    //Public Variables
    
    //Private Variables
    
    public void OnGUI() 
    {
    GUI.BeginGroup(new Rect((float)(Screen.width / 2 - 50), (float)(Screen.height / 2 - 50), 100.0f, 175.0f));
    
    //make a box to see the group on screen
    GUI.Box (new Rect(0.0f,0.0f,100.0f,175.0f), "Main Menu");
    
    //Add buttons for game navigation
    if(GUI.Button (new Rect(10.0f,30.0f,80.0f,30.0f), "Start Game"))
    	{
    		Application.LoadLevel ("Game");
    	}
    if(GUI.Button (new Rect(10.0f,65.0f,80.0f,30.0f), "Exit"))
    	{
    		Application.Quit();
    	}
    if(GUI.Button (new Rect(10.0f,100.0f,80.0f,30.0f), "Homepage"))
    	{
    		Application.OpenURL ("http://aigde.blogspot.com/");
    	}
    	GUI.EndGroup();
    }
}