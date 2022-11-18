using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{
    //
    private float spaceLimits = 3.5f;
    //Distance between squares
    private float distance = 1.75f; 
    private Vector3 nextPosition;

    void Update()
    {
        //Teleport movement
        //Movement Up
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != spaceLimits)
        {
            nextPosition = new Vector3(transform.position.x, transform.position.y + distance, transform.position.z);
            transform.position = nextPosition;
        }

        //Movement Down
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -spaceLimits)
        {
            nextPosition = new Vector3(transform.position.x, transform.position.y - distance, transform.position.z);
            transform.position = nextPosition;
        }

        //Movement Right
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != spaceLimits)
        {
            nextPosition = new Vector3(transform.position.x + distance, transform.position.y, transform.position.z);
            transform.position = nextPosition;
        }

        //Movement Left
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -spaceLimits)
        {
            nextPosition = new Vector3(transform.position.x - distance, transform.position.y, transform.position.z);
            transform.position = nextPosition;
        }
    }
}
