using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //print(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //print("Hello");

        if (Input.GetKeyUp(KeyCode.W))
        {
            //print("Hello");

            transform.position = new Vector3(0, transform.position.y + 0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            //print("Hello");

            transform.position = new Vector3(0, transform.position.y + -0.5f, 0);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            //print("Hello");

            transform.position = new Vector3( transform.position.x + -0.5f, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            //print("Hello");

            transform.position = new Vector3( transform.position.x + 0.5f, 0, 0);
        }
    }
}
