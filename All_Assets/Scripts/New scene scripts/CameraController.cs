using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cameraComponent;
    public float zoomSize = 0.01f;

    // Update is called once per frame
    void Update()
    {
        CameraSizeZoomInZoomOut();
    }
    void CameraSizeZoomInZoomOut()
    {
        //Input from button E and Q
        if(Input.GetKey(KeyCode.E) && (cameraComponent.orthographicSize<6) )
        {
            
            cameraComponent.orthographicSize += zoomSize;
        }

        if(Input.GetKey(KeyCode.Q) &&  (cameraComponent.orthographicSize>0.6))
        {
           
            cameraComponent.orthographicSize -= zoomSize;
        }
    }
}
