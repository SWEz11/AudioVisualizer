using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analyzer : MonoBehaviour
{
    // Start is called before the first frame update
    public float startTime;
    AudioSource source;
    public bool isPaused;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.time = startTime;
        isPaused = false;
    }

    public void PauseResume()
    {
        if (source.isPlaying)
        {
            source.Pause();
        }
        else
        {
            source.UnPause();
        }
    }

    public void SetTime(float time)
    {
        source.time = time;
    }


    public void Volume(float volume)
    {
        source.volume = volume;
    }
}
