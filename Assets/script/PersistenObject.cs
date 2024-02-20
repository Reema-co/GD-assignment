using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
