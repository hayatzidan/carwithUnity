using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class carmovementt : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    public float speed = 0f;       // Current speed
    public float tVelocity = 10f;  // Not used in logic but keeping it as you mentioned
    public float maxSpeed = 5f;    // Maximum speed

    void Update()
    {
        // Move forward
        if (Input.GetKey(KeyCode.W) && speed < maxSpeed)
        {
            speed += 0.1f;
        }

        // Move backward
        if (Input.GetKey(KeyCode.S) && speed > -maxSpeed)
        {
            speed -= 0.1f;
        }

        // Slow down when no key is pressed
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            if (speed > 0)
            {
                speed -= 0.1f;
            }
            else if (speed < 0)
            {
                speed += 0.1f;
            }
        }

        // Move the car
        transform.Translate(0, 0, speed);

        // Rotate only when moving
        if (speed != 0)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, -1, 0); // Turn left
            }
            else if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, 1, 0); // Turn right
            }
        }
    }
}



