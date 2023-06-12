using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarController : MonoBehaviour
{
    float speed = 1000.0f;
    private Rigidbody enemyRB;
    private GameObject player;
    private float turnSpeed = 70.0f;
    private float horizontalDirectionalPower = 1.0f;
    private float forwardDirectionalPower = 1.0f;
    [SerializeField] private float horsePower = 2500;

    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Set enemy direction towards player and move there
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;


        MoveEnemy(lookDirection);

        // enemyRB.AddForce(lookDirection * speed * Time.deltaTime);

    }

    void MoveEnemy(Vector3 lookDirection)
    {
        // Rotate about y-axis, 
        // transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalDirectionalPower);
        RotateTowardsEnemy();
        enemyRB.AddRelativeForce(Vector3.forward * horsePower * forwardDirectionalPower);
    }

    void RotateTowardsEnemy()
    {
        Vector3 directionVec = (player.transform.position - enemyRB.transform.position);
        enemyRB.transform.forward = directionVec;
    }
}
