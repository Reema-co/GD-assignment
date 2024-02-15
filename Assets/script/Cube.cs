using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sdisappear : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
    }
}