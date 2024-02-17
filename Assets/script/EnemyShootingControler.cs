using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class NewBehaviourScript : MonoBehaviour

[SerializeField] private GameObject myGameObject;
[SerializeField] private float m_shootingRate;




// Start is called before the first frame update
void Start()
{
    InvokeRepeating("Shoot", 0.0f, m_shootingRate);
}


private void Shoot()
{
    Instantiate(myGameObject, transform.position, Quaternion.identity);

}
