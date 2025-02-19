using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cartrafec : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(0, 0, 2);
        if (transform.position.z > 433)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -492);
        }


























    }
}
