using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControler : MonoBehaviour

{
    //[SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    [SerializeField] private string m_ignoreTag;

    private float m_speed;
    Rigidbody m_RigidBody;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        m_RigidBody = GetComponent<Rigidbody>();
    }


    public void Init(float speed)
    {
        m_speed = speed;
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        // transform.position += Vector3.forward * m_speed
        m_RigidBody.velocity = Vector3.forward * m_speed;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == m_ignoreTag)
        {
            Destroy(gameObject);
        }
    }
}
