using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analyzer : MonoBehaviour
{
    // Start is called before the first frame update
    public float startTime;
    AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.time = startTime;
    }

    public void Pause()
    {   
        source.Pause();
    }

    public void SetTime(float time)
    {
        source.time = time;
    }
}
