using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Rigidbody rb;
    public GameObject UIEND;

    private void Awake()
    {
        UIEND.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        
        rb.AddForce(transform.forward * 10, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collider other)
    {
        GameObject pups = other.gameObject;
        pups.SetActive(false);
        UIEND.SetActive(true);
    }
}
