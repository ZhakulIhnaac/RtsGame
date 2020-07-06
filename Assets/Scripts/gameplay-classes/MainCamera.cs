using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private float cameraSpeed;
    public float mouseMoveBorder = 10f;
    private float zoom;
    private float zoomConstant = 2f;
    private float maxYAxisZoomConstant;
    private float maxZAxisZoomConstant;
    private float minYAxisZoomConstant;
    private float minZAxisZoomConstant;
    private Vector3 pos;
    private float scrollData;

    void Start()
    {
        pos = transform.position;
        maxYAxisZoomConstant = pos.y + 2.5f;
        minYAxisZoomConstant = pos.y - 2.5f;
        maxZAxisZoomConstant = pos.z + 2.5f;
        minZAxisZoomConstant = pos.z - 2.5f;
    }

    void Update()
    {
        pos = transform.position;

        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            // Zoom in and Zoom out
            pos.y -= zoomConstant * Input.GetAxis("Mouse ScrollWheel");
            //pos.z += zoomConstant * Input.GetAxis("Mouse ScrollWheel");
            pos.y = Mathf.Clamp(pos.y, minYAxisZoomConstant, maxYAxisZoomConstant);
            //pos.z = Mathf.Clamp(pos.z, minZAxisZoomConstant, maxZAxisZoomConstant);
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


        if (Input.anyKey)
        {
            // Speeding up the camera speed with right shift key
            if (Input.GetKey(KeyCode.RightShift)) // TODO: Camera speeds has been given the zero values, change them when tests completed.
            {
                cameraSpeed = 30f;
            }
            else
            {
                cameraSpeed = 20f;
            }
            
        }

        transform.position = pos;

    }
}
