using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magia : MonoBehaviour
{
    public GameObject ZACRITO;
    public GameObject OTKRITO1;
    public GameObject OTKRITO2;
    public AudioSource _OPEN;
    public AudioSource _CLose;
    int collidersinfo = 0;
    void Start()
    {
        
        OTKRITO1.SetActive(false);
        OTKRITO2.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)       
    {
        if(collidersinfo < 1)
        {
            _OPEN.Play();
        }
        
        collidersinfo++;    
        ZACRITO.SetActive(false);
        OTKRITO1.SetActive(true);
        OTKRITO2.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        collidersinfo -= 1;
        if (collidersinfo == 0)
        {
            _CLose.Play();
            ZACRITO.SetActive(true);
            OTKRITO1.SetActive(false);
            OTKRITO2.SetActive(false);
        }         
    }
}
