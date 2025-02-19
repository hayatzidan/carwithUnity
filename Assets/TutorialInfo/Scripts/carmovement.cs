using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmovement : MonoBehaviour
{
    public float speed = 0f;
    public float maxspeed = 100f;

    // Update is called once per frame
    void Update()
    {
        // Moving forward (W key)
        if (Input.GetKey(KeyCode.W))
        {
            if (speed < maxspeed)
            {
                speed = speed + 0.1f;  // Accelerate
            }
        }
        // slowing down when not accelerating backwards
        if (Input.GetKey(KeyCode.S) && speed > 0)
        {
            speed = speed - 0.1f;
            if (speed < 0) 
            {
                speed = 0;
            } 
        }

        // Turning left when the car has some speed (A key)
        if (Input.GetKey(KeyCode.A) && speed != 0)
        {
            transform.Rotate(0, speed, 0);
        }

        // Turning right when the car has some speed (D key)
        if (Input.GetKey(KeyCode.D) && speed != 0)
        {
            transform.Rotate(0, -speed, 0);
        }
        // slow down or brake when the S key is pressed
        if (Input.GetKey(KeyCode.S))
        {
            speed = speed - 0.1f;
        }
        // slowing down when not accelerating 
        if (!Input.GetKey(KeyCode.W) && speed < 0)
        {
            speed = speed + 0.1f;
            if (speed > 0)
            {
                speed = 0;
            }
        }

        // Applying the movement (forward based on speed)
        transform.Translate(Vector3.forward * speed);

        Debug.Log(speed);
        if (transform.position.z > 433)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -492);
        }
    }
}

