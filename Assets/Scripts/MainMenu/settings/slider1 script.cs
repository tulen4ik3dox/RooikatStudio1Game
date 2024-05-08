using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider1script : MonoBehaviour
{
    [SerializeField] private Slider volume;
    public void changevolume()
    {
        AudioListener.volume = volume.value;
    }

}
