using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzlechenke : MonoBehaviour
{
    public puzlmaster pm1;
    public puzlmaster1 pm2;
    public puzlmaster2 pm3;

    void Update()
    {
        if (pm1._in  && pm2._in && pm3._in)
        {
            gameObject.SetActive(false);
        }
    }
}
