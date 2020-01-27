﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float speed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.D))
     {
         transform.Translate(new Vector3(speed * Time.deltaTime,0,0), Space.World);
     }
     if(Input.GetKey(KeyCode.A))
     {
         transform.Translate(new Vector3(-speed * Time.deltaTime,0,0), Space.World);
     }
     if(Input.GetKey(KeyCode.S))
     {
         transform.Translate(new Vector3(0,0, -speed * Time.deltaTime), Space.World);
     }
     if(Input.GetKey(KeyCode.W))
     {
         transform.Translate(new Vector3(0,0, speed * Time.deltaTime), Space.World);
     }

    float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
    float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
    transform.localRotation = Quaternion.Euler(new Vector4(-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    }
}
