using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment5 : MonoBehaviour
{
    Vector3 forward = new Vector3(0, 0, 1.0f);
    Vector3 Backward = new Vector3(0, 0, -1.0f);
    Vector3 right = new Vector3(2.0f,0);
    Vector3 left = new Vector3(-1.0f,0);


    public Rigidbody FristRigidBody;

    public void Awake()
    {
        FristRigidBody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        {
            if (Input.GetKey(KeyCode.UpArrow))
                FristRigidBody.velocity = Vector3.forward;
        }

        {
            if (Input.GetKey(KeyCode.DownArrow))
                FristRigidBody.velocity = Vector3.back;
        }

        {
            if (Input.GetKey(KeyCode.RightArrow))
                FristRigidBody.velocity = Vector3.right;
        }
        {
            if (Input.GetKey(KeyCode.LeftArrow))
                FristRigidBody.velocity = Vector3.left;
        }
    }

}

