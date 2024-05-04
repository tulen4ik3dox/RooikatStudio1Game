using UnityEngine;

public class GeneratorClew : MonoBehaviour
{

    public GameObject _RealyClew;
    public GameObject _CopyClew;
    public GameObject _NewClew;
    public float _force;
    public clew _script;
    public Vector2 positionMouse0 = new Vector2(0, 0);
    public int _plusOrMinus;
    public bool _lauched;
    public int _clewTo;

    void Update()
    {

        Vector2 positionMouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (positionMouse0.x < positionMouse.x)
        {
            _plusOrMinus = 1;
        }
        else if (positionMouse0.x > positionMouse.x)
        {
            _plusOrMinus = -1;
        }

        transform.position = _RealyClew.transform.position;


        if (_script._lauchCopy && _script._lauchIndex == 0)
        {
            Debug.Log("AAAAAAAAAA");
            FourceTo(_plusOrMinus);
        }

        positionMouse0 = positionMouse;

    }
    public void FourceTo(int _to)
    {
        GameObject _copy = Instantiate(_CopyClew, _NewClew.transform);
        _copy.transform.position = transform.position;
        _script._lauchIndex = 1;
        _lauched = true;
        _clewTo = _to;
    }
}
