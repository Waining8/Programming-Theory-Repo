using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public bool isUser;
    public GameObject mainCamera;
    private int m_Speed = 1;
    public int speed {
        get { return m_Speed; }
        set{
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
                speed = value;
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        if (isUser)
        {
            if(Input.GetKey(KeyCode.W))
            {
                moveForward(speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                moveLeft(speed);
            }
            if (Input.GetKey(KeyCode.D))
            {
                moveRight(speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                moveBackward(speed);
            }
        }
    }
    private void LateUpdate()
    {
        if (isUser)
        {
        mainCamera.transform.position = transform.position + new Vector3(0, 7, 0);
        }
    }

    public virtual void moveBackward(int tSpeed)
    {
        transform.Translate(Vector3.back * Time.deltaTime * tSpeed);
    }

    public virtual void moveRight(int tSpeed)
    {
        transform.Translate(Vector3.right * Time.deltaTime * tSpeed);
    }

    public virtual void moveLeft(int tSpeed)
    {
        transform.Translate(Vector3.left * Time.deltaTime * tSpeed);
    }

    public virtual void moveForward(int tSpeed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * tSpeed);
    }

    public void turnOffUser()
    {
        isUser = false;
    }
    public void turnOnUser()
    {
        isUser = true;
    }
}
