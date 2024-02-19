using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemycontroler : MonoBehaviour
{
    private ScoreCounter m_scoreCounter;

    [SerializeField] private EnemyData m_data;
    [SerializeField] private int m_MaxHealth = 5;

    int m_health;

    // Start is called before the first frame update
    void Start()
    {
        m_scoreCounter = FindObjectOfType<ScoreCounter>();
    }

    // Update is called once per frame
    void Update()
    {

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
