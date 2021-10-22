using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    //Get curiosity transform
    public Transform targetObject;
    // Get the offset between camera & Curiosity
    public Vector3 cameraOffset;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //The camera offset = curiosity - camera position
        cameraOffset = transform.position - targetObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // The new position of the camera = Curiosity + camera offset
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        // Make sure the camera position keep updated with the new position
        transform.position = newPosition;
    }
}
