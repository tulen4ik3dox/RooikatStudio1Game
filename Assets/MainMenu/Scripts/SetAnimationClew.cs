using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimationClew : MonoBehaviour
{
    public Animator _Clew;
    public Vector2 positionMouse0 = new Vector2(0, 0);


    public void Update()
    {
        Vector2 positionMouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (positionMouse0.x < positionMouse.x)
        {
            _Clew.SetBool("Stop", false);
            _Clew.SetBool("ToRight", true);
            _Clew.SetBool("ToLight", false);
        }
        else if (positionMouse0.x > positionMouse.x)
        {
            _Clew.SetBool("Stop", false);
            _Clew.SetBool("ToLight", true);
            _Clew.SetBool("ToRight", false);
        }
        else if ( positionMouse0.x == positionMouse.x)
        {
            _Clew.SetBool("Stop", true);
            _Clew.SetBool("ToRight", false);
            _Clew.SetBool("ToLight", false);
        }

        positionMouse0 = positionMouse;
    }
}
