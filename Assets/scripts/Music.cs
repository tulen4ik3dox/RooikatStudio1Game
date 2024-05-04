using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource musicsourse;
    float musicvolume = 1f;
    void Update()
    {
        musicsourse.volume = musicvolume;   
    }
    public void Setvolume(float vol)
    {
        musicvolume = vol;
    }
}
