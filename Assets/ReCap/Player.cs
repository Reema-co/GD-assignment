using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletSpawn;


    private Rigidbody myRigidbody;


    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        bool moving = false;

        //this is how to move more realistic
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody.velocity += Vector3.forward;
            moving = true;
            //this is how to move non-realistic
            //transform.position = transform.position + Vector3.forward;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity += Vector3.right;
            moving = true;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity += Vector3.left;
            moving = true;

        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidbody.velocity += Vector3.back;
            moving = true;
        }

        // Here is How to Shooting
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            Shoot();
        }

        // Here is How to Jump
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            myRigidbody.AddForce(Vector3.up * 7, ForceMode.Impulse);
        }

        // this is how to make it stop moving 
        if (moving == false)
        {
            myRigidbody.velocity = new Vector3(0, myRigidbody.velocity.y, 0);
        }

    }
    private IEnumerator Shoot()
    {
        Instantiate(bullet, bulletSpawn.position, Quaternion.identity);

    }
}
