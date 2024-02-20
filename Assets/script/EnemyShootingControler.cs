using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class EnemyShootingControler : MonoBehaviour
{
    [SerializeField] private GameObject my_GameObject;
    [SerializeField] private float m_shootingRate;
    [SerializeField] private EnemyData EnemyData;




    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("Shoot", 0.0f, m_shootingRate);
        StartCoroutine(MyCoroutine(5.0f));

    }
    private IEnumerator MyCoroutine(float time)
    {
    Debug.Log ("begin waiting for 5 seconds");
        yield return new WaitForSeconds(time);
    Debug.Log ("Done waiting for 5 seconds");
    }

    private void Shoot()
    {
        Instantiate(my_GameObject, transform.position, Quaternion.identity);

    }
}