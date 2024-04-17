using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magia : MonoBehaviour
{
    public GameObject ZACRITO;
    public GameObject OTKRITO1;
    public GameObject OTKRITO2;
    int collidersinfo = 0;
    void Start()
    {
        
        OTKRITO1.SetActive(false);
        OTKRITO2.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)       
    {    
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
            ZACRITO.SetActive(true);
            OTKRITO1.SetActive(false);
            OTKRITO2.SetActive(false);
        }         
    }
}
