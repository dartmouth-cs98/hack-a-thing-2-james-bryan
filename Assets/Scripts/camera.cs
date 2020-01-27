using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    float speed = 2.0f;
    private CharacterController _charCont;
    // Start is called before the first frame update
    void Start()
    {
        _charCont = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
     // if(Input.GetKey(KeyCode.D))
     // {
     //     transform.Translate(new Vector3(speed * Time.deltaTime,0,0), Space.World);
     // }
     // if(Input.GetKey(KeyCode.A))
     // {
     //     transform.Translate(new Vector3(-speed * Time.deltaTime,0,0), Space.World);
     // }
     // if(Input.GetKey(KeyCode.S))
     // {
     //     transform.Translate(new Vector3(0,0, -speed * Time.deltaTime), Space.World);
     // }
     // if(Input.GetKey(KeyCode.W))
     // {
     //     transform.Translate(new Vector3(0,0, speed * Time.deltaTime), Space.World);
     // }
    float deltaX = Input.GetAxis("Horizontal") * speed;
    float deltaY = Input.GetAxis("Vertical") * speed;

    Vector3 mvmt = new Vector3(deltaX, 0, deltaY);
    mvmt = Vector3.ClampMagnitude(mvmt, speed);
    // mvmt.y = -9.8f;
    mvmt = transform.TransformDirection(mvmt); 

    _charCont.Move(mvmt);


    float mouseX = (Input.mousePosition.x / Screen.width) - 0.5f;
    float mouseY = (Input.mousePosition.y / Screen.height) - 0.5f;
    transform.localRotation = Quaternion.Euler(new Vector4(-1f * (mouseY * 180f), mouseX * 360f, transform.localRotation.z));
    }
}
