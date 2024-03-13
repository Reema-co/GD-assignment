using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }
    // here will make a manger for each scene in the game 
    public void LoadSceneOne()
    {
        StartCoroutine(LoadSceneCoroutine("ReCap"));
    }
    public void LoadSceneTwo()
    {
        StartCoroutine(LoadSceneCoroutine("SampleScene"));
    }

    private IEnumerator LoadSceneCoroutine(string sceneName)
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
        while (!op.isDone)
        {
            yield return null;
        }
    }

}
