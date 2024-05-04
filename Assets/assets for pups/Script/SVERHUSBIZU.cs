using UnityEngine;

public class SVERHUSBIZU : MonoBehaviour
{
    public Renderer _renderer;
    public int _check = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        _TrigTrig pers = other.GetComponent<_TrigTrig>();
        _check++;
        if (pers != null && _check == 1)
        {
            _renderer.sortingOrder -= 10;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        _TrigTrig pers = other.GetComponent<_TrigTrig>();
        _check--;
        if (pers != null && _check == 0)
        {
            _renderer.sortingOrder += 10;

        }
    }

}
