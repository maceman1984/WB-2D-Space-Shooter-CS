using UnityEngine;
using System;


public class scriptScreenLose:MonoBehaviour
{
    //lose script
    
    //Public Variables
    public string loseQuote = "You Lose!";
    
    //Private Variables
    
    public void OnGUI() 
    {
    //Make a group in the center of the screen
    GUI.BeginGroup (new Rect((float)(Screen.width / 2 - 100), (float)(Screen.height / 2 - 100), 200.0f, 100.0f));
    
    //make a box to see the group name
    GUI.Box (new Rect(0.0f,0.0f,200.0f,100.0f), loseQuote); 	//Or use the designer Input 
    
    //Add buttons here
    if(GUI.Button(new Rect(60.0f,60.0f,80.0f,30.0f), "Main Menu")) 
    {
    Application.LoadLevel ("ScreenStartMenu");
    }
    
    GUI.EndGroup();
    }
}