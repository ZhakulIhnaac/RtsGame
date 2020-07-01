using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private float cameraSpeed = 0f;
    public float mouseMoveBorder = 10f;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 pos = transform.position;

        //Shift key control
        if (Input.GetKey(KeyCode.RightShift))
        {
            cameraSpeed = 0f;
        }
        else
        {
            cameraSpeed = 0f;
        }

        //Movement control
        if (Input.GetKey(KeyCode.UpArrow) || Input.mousePosition.y > Screen.height - mouseMoveBorder)
        {
            pos.z += cameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.mousePosition.x > Screen.width - mouseMoveBorder)
        {
            pos.x += cameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.mousePosition.y < mouseMoveBorder)
        {
            pos.z -= cameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.mousePosition.x < mouseMoveBorder)
        {
            pos.x -= cameraSpeed * Time.deltaTime;
        }

        transform.position = pos;
    }
}
