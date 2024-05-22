using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E : MonoBehaviour
{
    [SerializeField] public GameObject e;

    private void Awake()
    {
        e.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        pupshodit hohpups = collision.GetComponent<pupshodit>();
        if (hohpups != null)
        {
            e.SetActive (true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pupshodit hohpups = collision.GetComponent<pupshodit>();
        if (hohpups != null)
        {
            e.SetActive(false);
        }
    }
}
