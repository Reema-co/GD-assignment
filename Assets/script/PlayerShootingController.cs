using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerShootingController : MonoBehaviour
{

    [SerializeField] private GameObject myGameObject;
    [SerializeField] private float m_shootingRate;
    [SerializeField] private float m_BulletSpeed;
    [SerializeField] private Button PauseController;


    private PauseState m_PauseController;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.T))
        //{
        // GameObject gol1 = Instantiate(myGameObject);
        // Destroy(gol1, 10f);

        // }

        if (Input.GetKeyDown(KeyCode.T))

        {

            InvokeRepeating("Shoot", 0.0f, 0.5f);

        }

        if (Input.GetKeyUp(KeyCode.T))
        {
            CancelInvoke();
        }

    }

    private void FixedUpdate()
    {

    }


    private void Shoot()
    {
        GameObject newBullet = Instantiate(myGameObject, transform.position, Quaternion.identity);
        newBullet.GetComponent<BulletControler>().Init(m_BulletSpeed);
    }
}
