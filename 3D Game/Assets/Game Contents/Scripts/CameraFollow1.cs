using UnityEngine;

public class CameraFollow1 : MonoBehaviour
{
    // The player to follow
    public Transform target;

    // The slight camera delay for nice effect
    public float smoothSpeed;

    // Where to wtach from
    public Vector3 offset; //= new Vector3(0.0f, 2.7f, -5.2f);

    private void FixedUpdate()
    {
        Vector3 desiredPos = target.position + offset;
        Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);

        transform.position = smoothedPos;

        transform.LookAt(target);
    }
}
