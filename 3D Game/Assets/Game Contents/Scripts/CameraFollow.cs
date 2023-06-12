using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // The player to follow
    public GameObject target = null;
    // The target view
    public GameObject t = null;

    // Speed of camera
    public float speed = 10.5f;

    public float lessLagVar = 10.0f;

    // For camera switching later on
    public int index;


    private void Start()
    {
        // Sets the right objects to be used
        target = GameObject.FindGameObjectWithTag("Player");
        t = GameObject.FindGameObjectWithTag("Target");

    }

    private void FixedUpdate()
    {
        this.transform.LookAt(target.transform);
        float car_move = Mathf.Abs(Vector3.Distance(this.transform.position, t.transform.position) * speed * lessLagVar);
        this.transform.position = Vector3.MoveTowards(this.transform.position, t.transform.position, car_move * Time.deltaTime);
    }
}
