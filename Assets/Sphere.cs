using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewScript : MonoBehaviour
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
}