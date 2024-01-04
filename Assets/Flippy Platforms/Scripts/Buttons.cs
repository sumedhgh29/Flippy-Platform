using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Buttons : MonoBehaviour
{
    public string input;
    public bool motion;
    public float speed = 0.5f;

    void Update()
    {      
        if (motion)
        {
            if (input.ToUpper().Equals("A"))
            {
                transform.Rotate(Vector3.forward * speed);
            }

            if (input.ToUpper().Equals("C"))
            {
                transform.Rotate(-Vector3.forward * speed);
            }
        } 
    }

    public void RotateObject(string temp)
    {
        input = temp;
        motion = true;
    }

    public void StopObject()
    {
        motion =  false;
    }
}







