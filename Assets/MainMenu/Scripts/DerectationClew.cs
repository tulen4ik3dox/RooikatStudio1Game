using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerectationClew : MonoBehaviour
{
    public GeneratorClew _script;
    public float force;

    void Update()
    {
        if (_script._lauched)
        {
            transform.position = transform.right * _script._clewTo * force * Time.deltaTime;
        }
    }
}
