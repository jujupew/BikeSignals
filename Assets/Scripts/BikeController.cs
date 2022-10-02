using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    public float speed;
    public int angle;
    public string direction;
    public bool canTurn;
    //public bool indicateTurn;
    public bool hasNotIndicated;
    private Rigidbody2D rb2d;
    public GameObject IndicationGrab;
    public int tickets;
    


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        angle = 0;
        tickets = 0;
        rb2d.freezeRotation = true;
        //indicateTurn = false;
        

    }

    // Update is called once per frame
    void Update()
    {
        CheckLeft();
        CheckRight();
        CheckAngle();

        
        //Indication IndScript = IndicationGrab.GetComponent<Indication>();
        hasNotIndicated = Indication.canIndicate;
        //Debug.Log(IndScript.canIndicate);
        
        
    }

     void CheckLeft()
     {
        //Indication IndScript = IndicationGrab.GetComponent<Indication>();
        //hasNotIndicated = IndScript.canIndicate;
        //If Certain Keys are pressed
        // Begin to Rotate the Player in the Correct Direction, In a few Sections 
        if (Input.GetKeyDown("left") == true && canTurn)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z += 90;  //this number is the degree of rotation around Z Axis
            transform.rotation = Quaternion.Euler(rotationVector);
            angle += 90;

            if (hasNotIndicated)
            {
                //add a value to ticket
                tickets += 1;
            }
        }// assets packees package settings user settings  make new folder, web gL build, paper report - short description one line, then compress top folder, upload zip file
     }
     void CheckRight()
     {
        //If Certain Keys are pressed
        //Begin to Rotate the Player in the Correct Direction, In a few Sections 
        if (Input.GetKeyDown("right") == true && canTurn)
        {
            var rotationVector = transform.rotation.eulerAngles;
            rotationVector.z -= 90;  //this number is the degree of rotation around Z Axis
            transform.rotation = Quaternion.Euler(rotationVector);
            angle -= 90;

            if (hasNotIndicated)
            {
                // add value to ticket
                tickets += 1;
            }
        }
        


       
    }
    void CheckAngle()

        {
        Vector2 vel = rb2d.velocity;
            if (angle == 90 || angle == -270)
            {
            direction = "left";

            vel.y = 0;
            vel.x = speed * (-1);
            rb2d.velocity = vel;

            }

            if (angle == 180 || angle == -180)
            {
            direction = "back";
            vel.y = speed * (-1);
            vel.x = 0;
            rb2d.velocity = vel;
        }

            if (angle == 270 || angle == -90)
            {
            direction = "right";
            vel.y = 0;
            vel.x = speed;
            rb2d.velocity = vel;
        }

            if (angle == 360 || angle == -360 || angle == 0)
            {
            direction = "straight";
            angle = 0;

            vel.y = speed;
            vel.x = 0;
            rb2d.velocity = vel;
        }


    }
   
}
