using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzlmaster1 : MonoBehaviour
{
    public GameObject rune;
    public Rigidbody2D rb;
    public bool _in = false;

    void Start()
    {
        rune.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        puzle1 _pauzle = other.GetComponent<puzle1>();
        if (_pauzle != null )
        {
            Transform target = other.transform;
            rb.velocity = (transform.position - target.transform.position) * 2;
            _in = true;
        }
    }
}