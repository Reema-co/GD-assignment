using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward;
            //transform.position = transform.position + Vector3.forward;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
