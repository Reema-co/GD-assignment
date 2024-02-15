using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Vector3 forwardMove = new Vector3(0.2f, 0, 0);
    Vector3 BackourdMove = new Vector3(-0.1f, 0, 0);
    Vector3 RightMove = new Vector3(0, 0, -0.1f);
    Vector3 leftMove = new Vector3(0, 0, 0.1f);

    Vector3 Upwards = new Vector3(0,1,0);
    Vector3 Downwards = new Vector3(0, -1, 0);


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += forwardMove;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += BackourdMove;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += RightMove;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += leftMove;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += Upwards;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += Downwards;
        }
    }
}
