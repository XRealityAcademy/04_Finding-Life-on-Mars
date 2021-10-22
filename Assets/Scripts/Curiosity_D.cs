using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curiosity_D : MonoBehaviour
{
    public float playerSpeed = 10.0f;

    public float playerRotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // get the horizontal and vertical axis using arrow keys
        // the value is in the range between -1 to 1
        // Make it move 10 meters per second instead of 10 metters per frame

        float translation = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * playerRotationSpeed * Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0,rotation,0);

    }
}
