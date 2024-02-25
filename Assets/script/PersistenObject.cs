using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PersistenObject : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        StartCoroutine(LaodLevelLater());
    }

    private IEnumerator LaodLevelLater()
    {
        yield return new WaitForSeconds(10.0f);
        SceneManager.LoadScene("");
    }
}
