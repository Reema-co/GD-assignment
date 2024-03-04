using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    [SerializeField] AudioSource resumeAudio;
    [SerializeField] AudioSource pauseAudio;

    public void PauseGame()
    {
        Time.timeScale = 0;
        resumeAudio.Play();


    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
        resumeAudio.Play();
    }
}
