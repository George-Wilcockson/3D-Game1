using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    // private float speed = 15.0f; No longer needed as using forces
    private float turnSpeed = 70.0f;
    private float horizontalInput;
    private float forwardInput;

    // Making the car use forces to look realistic
    [SerializeField] private float horsePower = 10000;
    private Rigidbody playerRB;
    [SerializeField] GameObject centreOfMass;

    // List of wheel colliders to check if they are on the ground
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

        // Set the centre of mass of the rigid body to be where we put one on the vehicle
        playerRB.centerOfMass = centreOfMass.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (IsOnGround())
        {
            // Move the vehicle
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            playerRB.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        }
    }

    // checks if all wheels are on ground to then make determine if driver inout can be accepted
    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround >= 2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
