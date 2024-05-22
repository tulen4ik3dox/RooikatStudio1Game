using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzlechenke : MonoBehaviour
{
    public int cumni = 1;
    public AudioSource ss;

    void Update()
    {
        if (cumni == 4)
        {
            gameObject.SetActive(false);
            ss.Play();  
        }
    }
}
