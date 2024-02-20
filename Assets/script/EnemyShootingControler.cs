using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyShootingControler : MonoBehaviour
{
    [SerializeField] private GameObject my_GameObject;
    //[SerializeField] private float m_shootingRate;
    [SerializeField] private EnemyData m_enemyData;


    private Coroutine m_corouine;


    void Start()
    {
        //InvokeRepeating("Shoot", 0.0f, m_shootingRate);
        //InvokeRepeating("Shoot", 0.0f, EnemyData.ShootingRate);
        StartCoroutine(ShootingCoroutine(5.0f));
    }


    private IEnumerator ShootingCoroutine(float time)
    {
        while (true)
            for (int i = 0; i < 3; i++)
            {
                Shoot();
                yield return new WaitForSeconds(0.3f);
            }
        Shoot();
        yield return new WaitForSeconds(m_enemyData.ShootingRate);
        Debug.Log("begin waiting for 5 seconds");
        Debug.Log("Done waiting for 5 seconds");
    }


    private void Shoot()
    {
        GameObject newBullet = Instantiate(my_GameObject, transform.position, Quaternion.identity);
        newBullet.GetComponent<BulletControler>().Init(m_enemyData.BulletSpeed);

    }
}