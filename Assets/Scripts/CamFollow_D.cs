using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow_D : MonoBehaviour
{
    public Transform targetObject;
    public Vector3 cameraOffset;
    // Start is called before the first frame update
    void Start()
    {
        // The camera offset =  camera position -  curiosity position
        cameraOffset = transform.position - targetObject.transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = targetObject.transform.position + cameraOffset;
        transform.position = newPosition;
    }
}
