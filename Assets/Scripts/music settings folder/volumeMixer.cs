using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class volumeMixer : MonoBehaviour
{
    [SerializeField] public AudioMixer myMixer;
    [SerializeField] public Slider musicSlider;
    [SerializeField] public Slider SFXSlider;
    private void Start()
    {
        if (PlayerPrefs.HasKey("musicvolume"))
        {
            loadvolume();
        }
        else
        {
            setmusicvolume();
            setSFXvolume();
        }
    }
    public void setmusicvolume()
    {
        float volume = musicSlider.value;
        myMixer.SetFloat("music", Mathf.Log10(volume)*20 );
        PlayerPrefs.SetFloat("musicvolume", volume);
    }
    public void setSFXvolume()
    {
        float volume = SFXSlider.value;
        myMixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
        PlayerPrefs.SetFloat("SFXvolume", volume);
    }
    private void loadvolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicvolume");
        SFXSlider.value = PlayerPrefs.GetFloat("SFXvolume");

        setmusicvolume();
        setSFXvolume();
    }
    
}
