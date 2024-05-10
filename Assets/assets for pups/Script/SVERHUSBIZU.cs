using UnityEngine;

public class SVERHUSBIZU : MonoBehaviour
{
    public Renderer _renderer;
    public int _check = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _TrigTrig pers = other.GetComponent<_TrigTrig>();
        SVERHUSBIZU sver = other.GetComponent<SVERHUSBIZU>();
        _check++;
        if (pers != null && _check == 1 && sver == null)
        {
            _renderer.sortingOrder -= 10;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        _TrigTrig pers = other.GetComponent<_TrigTrig>();
        _check--;
        SVERHUSBIZU sver = other.GetComponent<SVERHUSBIZU>();
        if (pers != null && _check == 0 && sver == null)
        {
            _renderer.sortingOrder += 10;

        }
    }

}
