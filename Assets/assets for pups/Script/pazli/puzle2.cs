using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzle2 : MonoBehaviour
{
    public AudioSource Sone;
    public Vector2 positionMouse0 = new Vector2(0, 0);


    public void Update()
    {
        Vector2 positionMouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (positionMouse0.x < positionMouse.x)
        {
            Sone.Play();
        }
        else if (positionMouse0.x > positionMouse.x)
        {
            Sone.Play();
        }
        else if (positionMouse0.x == positionMouse.x)
        {
            Sone.Stop();
        }

        positionMouse0 = positionMouse;
    }
}
