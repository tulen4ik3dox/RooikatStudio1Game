using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class INtersnodialog : MonoBehaviour
{
    public GameObject pups;
    public List<GameObject> texts;
    public bool v1ras = true;
    public GameObject textpole;
    

    void OnTriggerEnter2D (Collider2D sollsion)
    {
        pupshodit pup = sollsion.GetComponent<pupshodit>();
        if ( v1ras ==true && pup != null)
        {
            textpole.SetActive(true);
            texts[0].SetActive(true);
            gameObject.GetComponent<Collider2D>().enabled = false;
            v1ras = false;
        }
    }
}
