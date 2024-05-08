using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatWithGruz : MonoBehaviour
{
    public bool _ok = false;
    public bool _light = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Gruzovik gruzovik = collision.GetComponent<Gruzovik>();
        if (gruzovik != null)
        {
            _ok = true;
        }

        TimeStop gruzovik1 = collision.GetComponent<TimeStop>();
        if (gruzovik1 != null)
        {
            _light = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Gruzovik gruzovik = collision.GetComponent<Gruzovik>();
        if (gruzovik != null)
        {
            _ok = false;
        }

        TimeStop gruzovik1 = collision.GetComponent<TimeStop>();
        if (gruzovik1 != null)
        {
            _light = false;
        }
    }

}