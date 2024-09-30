using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeControl : MonoBehaviour
{
        float xRotation = 0;
        float yRotation = 0;
       
        void Start()
    {
        
        }
    void Update()
    {
       
               xRotation = Input.GetAxis("Vertical") * 2;
        
               yRotation = Input.GetAxis("Horizontal") * -2;

        transform.rotation = Quaternion.Euler(xRotation, 0, yRotation);
    }
}
