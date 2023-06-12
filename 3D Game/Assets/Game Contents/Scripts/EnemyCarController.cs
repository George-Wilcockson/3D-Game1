using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCarController : MonoBehaviour
{
    private Rigidbody enemyRB;
    private GameObject player;
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
        RotateTowardsEnemy();

        // Move towards enemy
        enemyRB.AddRelativeForce(Vector3.forward * horsePower);
    }

    void RotateTowardsEnemy()
    {
        Vector3 directionVec = (player.transform.position - enemyRB.transform.position);
        enemyRB.transform.forward = directionVec;
    }
}
