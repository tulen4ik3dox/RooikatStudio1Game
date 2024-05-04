using UnityEngine;
using UnityEngine.UI;



public class clew : MonoBehaviour
{
    public GameObject _Clew;
    public Image _ClewImage;
    public bool _lauchCopy = false;
    public int _lauchIndex = 0;
     

    public void OnMouseOver()
    {
        _lauchCopy = true;
        Cursor.visible = true;
        _ClewImage.gameObject.SetActive(false);
    }

    public void OnMouseExit()
    {
        _lauchCopy = false;
        Cursor.visible = false;
        _ClewImage.gameObject.SetActive(true);
        _lauchIndex = 0;
    }

    public void Update()
    {
        _Clew.transform.position = Input.mousePosition;
    }
}
