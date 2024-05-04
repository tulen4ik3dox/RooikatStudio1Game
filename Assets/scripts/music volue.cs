using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicvolue : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    float musicvolume = 1f;
    void Update()
    {
        audioSource.volume = musicvolume;

    }
    public void Setvolume(float vol)
    {
        musicvolume = vol;
    }
}
