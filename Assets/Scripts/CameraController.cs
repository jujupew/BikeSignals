using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckLeft();
        CheckRight();
    }


    void CheckLeft()
    {
        //If Certain Keys are pressed
        // Begin to Rotate the Player in the Correct Direction, In a few Sections 
        if (Input.GetKeyDown("left") == true)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = 60;  //this number is the degree of rotation around Z Axis
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }
    void CheckRight()
    {
        //If Certain Keys are pressed
        //Begin to Rotate the Player in the Correct Direction, In a few Sections 
        if (Input.GetKeyDown("right") == true)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z = -60;  //this number is the degree of rotation around Z Axis
            transform.rotation = Quaternion.Euler(rotationVector);
        }
    }
}
