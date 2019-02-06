using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //calls move()
        move(); 
    }

    void move()
    {
        Cursor.lockState = CursorLockMode.Locked;
        //Moves Forward with WASD
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0f, 0.1f);
        }

        //Moves Back with WASD
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -0.1f);
        }

        //Moves Left with WASD
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0f, 0f);
        }

        //Moves Right with WASD
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f, 0f, 0f);
        }


        //Gets Mouse Axis
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        float z = 0;

        //Made the horizontal axis negative to correct the inverse mouse issue.
        transform.Rotate(-v, h, z);
        if ("Mouse Z" == 0)
        {
            transform.Rotate (0,0,-z);
        }

    }
}

//Assignment #2 - Lab 3: Part 1
//Submit C# Code that:
//  A) Resolves mouse look issue 
//  B) Resolve inverse mouse issue
//  Oiler Angles
//  Restict X axis, Don't use Z axis Euclidian
