using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 10f;     // Movement speed
    public float turnSpeed = 50f; // Rotation speed

    void Update()
    {
        // Move forward and backward
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        // Turn left and right
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }
    }
}