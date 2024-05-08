using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyClew : MonoBehaviour
{
    public float _force;
    public int _clewTo = 1;
    void Update()
    {
        transform.position += transform.right * _force * Time.deltaTime * _clewTo;
        if (transform.position.x > 2100 || transform.position.x < -300)
        {
            Destroy(gameObject);
        }
    }

}
