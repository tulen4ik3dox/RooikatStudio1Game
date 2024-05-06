using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzlmaster2 : MonoBehaviour
{
    public GameObject rune;
    public Rigidbody2D rb;
    private Transform self;
    public bool _in = false;

    void Start()
    {
        rune.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        puzle2 _pauzle = other.GetComponent<puzle2>();

        if (_pauzle != null )
        {
            Transform target = other.transform;
            rb.velocity = (transform.position - target.transform.position) * 2;
            _in = true;
        }
    }
}
