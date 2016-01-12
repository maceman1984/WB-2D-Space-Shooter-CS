using UnityEngine;
using System;


public class BackgroundScroll:MonoBehaviour
{
    
    //public variables 
    public float scrollSpeed;
    
    //private variables
    
    public void Update() 
    {
    renderer.material.SetTextureOffset("_MainTex", new Vector2(0.0f, Time.time * scrollSpeed) );
    }
}