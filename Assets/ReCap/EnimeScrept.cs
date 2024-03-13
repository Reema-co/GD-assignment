using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimeScrept : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletSpawn;

    void Start()
    {
        StartCoroutine(Shoot());
    }

    void Update()
    {

    }
    private IEnumerator Shoot()
    {

        while (true)
        {
            Instantiate(bullet, bulletSpawn.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }

    }
}
