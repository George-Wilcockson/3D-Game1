using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Private variables
    private float speed = 15.0f;
    private float turnSpeed = 35.0f;
    private float horizontalInput;
    private float forwardInput;

    // Making the car use forces to look realistic
    [SerializeField] private float horsePower = 10000;
    private Rigidbody playerRB;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        playerRB.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
    }
}