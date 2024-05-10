using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzle : MonoBehaviour
{
    public AudioSource Sone;
    private bool zvuchit;
    public Vector2 positionStone0 ;

    private void Start()
    {
         positionStone0 = new Vector2(transform.position.x, transform.position.y);
    }
    public void Update()
    {
        Vector2 positionStone = new Vector2(transform.position.x, transform.position.y);
        if (positionStone0 != positionStone)
        {
            if (zvuchit == false)
            {
                zvuchit = true;
                Sone.Play();

            }

        }
        else if (zvuchit != false)
        {
            zvuchit = false;
            Sone.Stop();

            
        }
        positionStone0 = positionStone;
    }
}