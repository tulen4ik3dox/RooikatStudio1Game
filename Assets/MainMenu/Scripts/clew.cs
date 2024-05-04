
using UnityEngine;


public class clew : MonoBehaviour
{
    public GameObject _Clew;
    public bool _on = true;

    public void OnMouseOver()
    {

        Cursor.visible = true;
        _Clew.SetActive(false);

    }

    public void OnMouseExit()
    {

        Cursor.visible = false;
        _Clew.SetActive(true);
    }

    public void Update()
    {

        _Clew.transform.position = Input.mousePosition;

    }
}
