using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeStop : MonoBehaviour
{
    public float _A;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CatWithGruz cat = collision.GetComponent<CatWithGruz>();
        if (cat != null)
        {
            Time.timeScale = _A;
        }

    }
}
