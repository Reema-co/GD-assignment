using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootiing : MonoBehaviour
{

    [SerializeField] private GameObject myGameObject;

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

            InvokeRepeating("Shoot", 0.0f,0.5f);

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
        Instantiate(myGameObject, transform.position, Quaternion.identity);

    }
}
