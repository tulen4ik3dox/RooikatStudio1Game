using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class puzlmaster : MonoBehaviour
{
    public GameObject rune;
    public Rigidbody2D rb;

    public puzlechenke cumni;

    void Start()
    {
        rune.SetActive(false);
    }

    private void Update()
    {
        if (Vector2.Distance(rb.transform.position, gameObject.transform.position) <0.05f)
        {           
            Destroy(rb);
            cumni.cumni++;
            rune.SetActive(true);
        }
    }
}
