using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemycontroler : MonoBehaviour
{
    private ScoreCounter m_scoreCounter;

    [System.Obsolete]

    [SerializeField] private EnemyData m_data;
    [SerializeField] private int m_MaxHealth = 5;

    int m_health;

    // Start is called before the first frame update
    [System.Obsolete]
    void Start() => m_scoreCounter = FindObjectOfType<ScoreCounter>();


    private IEnumerator MovementCoroutine()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        while (true)
        {
            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.up;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)

            {
                rb.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.down;
                yield return new WaitForFixedUpdate();
            }

            for (int i = 0; i < 200; i++)
            {
                rb.velocity = Vector3.zero;
                yield return new WaitForFixedUpdate();
            }
        }
    }



    private void OnCollisionEnter(Collision collision)

    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            --m_health;
            if (m_health <= 0)
            {
                m_scoreCounter.IncreaseCounter();
                Destroy(gameObject);
            }
        }
    }
}
