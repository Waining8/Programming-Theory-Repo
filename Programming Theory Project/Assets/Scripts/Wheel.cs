using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : Object
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public override void moveLeft(int tSpeed)
    {
        transform.Rotate(Vector3.forward, Time.deltaTime * tSpeed * 80);
    }
    public override void moveRight(int tSpeed)
    {
        transform.Rotate(Vector3.back, Time.deltaTime * tSpeed * 80);
    }
    public override void moveBackward(int tSpeed)
    {
        transform.Translate(Vector3.right * Time.deltaTime * tSpeed);
    }
    public override void moveForward(int tSpeed)
    {
        transform.Translate(Vector3.left * Time.deltaTime * tSpeed);
    }
}
