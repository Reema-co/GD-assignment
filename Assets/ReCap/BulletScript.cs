using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Rigidbody myRigidbody;
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

        Destroy(gameObject, 1f);
    }

    void Update()
    {
        myRigidbody.velocity += Vector3.forward;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("hello");
        Destroy(gameObject);

        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }

    }
}
