using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

/*public class NewScript : MonoBehaviour
{
    public float bulletSpeed = 1f;

    private void Awake()
    {
        Destroy(gameObject, 5.0f);
    }
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + transform.forward * bulletSpeed;
    }
*/


public class    Sphere : MonoBehaviour
{
    [SerializeField] private float m_speed;
    [SerializeField] private float m_lifetime;
    [SerializeField] private string m_ignoredTag;

    public Rigidbody FristRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, m_lifetime);
        FristRigidBody = GetComponent<Rigidbody>();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += Vector3.forward * m_speed;
        FristRigidBody.velocity = Vector3.forward * m_speed;

    }

    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag != m_ignoredTag)
        {
            Destroy(GameObject);
        }
    }


}