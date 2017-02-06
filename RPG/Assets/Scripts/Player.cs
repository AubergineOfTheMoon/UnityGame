using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Movement
{
    public float speed = 5f;

   

    public override void Move()
    {
        // Get Input
        moveVector.x = GetHorizontalInput() * speed * Time.deltaTime;        
        moveVector.z = GetVerticalInput() * speed * Time.deltaTime;
        //Move
        transform.Translate(moveVector);
    }


    

    // Use this for initialization DO NOT INITIALIZE IN UPDATE
    void Start ()
    {
        //Saves us 1/60(ish) of a second at the start to streamline the startup (rather than setting the y component in the updatde funct.
        moveVector.y = 0;

    }
	
	// Update is called once per frame
	void Update ()
    {
      
        
    }

    
    
}


