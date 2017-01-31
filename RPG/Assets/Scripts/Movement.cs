using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Movement : MonoBehaviour
{
    
    public Vector3 moveVector;

    public float GetHorizontalInput()
    {
        return Input.GetAxis("Horizontal");
    }

    public float GetVerticalInput()
    {
        return Input.GetAxis("Vertical");
    }

    abstract public void Move();   


}