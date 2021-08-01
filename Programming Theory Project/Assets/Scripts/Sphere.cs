using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Object
{
    public Rigidbody sphereRB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void Update()
    {
        if (isUser)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                moveForward(speed);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                moveLeft(speed);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                moveRight(speed);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                moveBackward(speed);
            }
        }
    }
    public override void moveLeft(int tSpeed)
    {
        sphereRB.AddForce(new Vector3(-.5f, 1, 0) * 200);
    }
    public override void moveRight(int tSpeed)
    {
        sphereRB.AddForce(new Vector3(.5f, 1, 0) * 200);
    }
    public override void moveBackward(int tSpeed)
    {
        sphereRB.AddForce(new Vector3(0, 1, -.5f) * 200);
    }
    public override void moveForward(int tSpeed)
    {
        sphereRB.AddForce(new Vector3(0, 1, .5f) * 200);
    }
}
