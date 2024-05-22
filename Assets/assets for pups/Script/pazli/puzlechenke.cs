using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzlechenke : MonoBehaviour
{
    public int cumni = 0;
    public AudioSource ss;

    void Update()
    {
        if (cumni == 3)
        {
            gameObject.SetActive(false);
            ss.Play();  
        }
    }
}
