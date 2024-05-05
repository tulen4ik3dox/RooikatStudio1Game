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
    public bool _lauched = false;
    public int _clewTo1;

    void Update()
    {
        Vector2 positionMouse = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        if (positionMouse0.x < positionMouse.x)
        {
            _plusOrMinus = -1;
        }
        else if (positionMouse0.x > positionMouse.x)
        {
            _plusOrMinus = 1;
        }
        transform.position = _RealyClew.transform.position;


        if (_script._lauchCopy && _script._lauchIndex == 1)
        {
            _clewTo1 = _plusOrMinus;
            FourceTo();
        }

        positionMouse0 = positionMouse;

    }
    public void FourceTo()
    {
        GameObject _copy = Instantiate(_CopyClew, _NewClew.transform);
        _copy.transform.position = transform.position;
        Debug.Log(_clewTo1);
        _copy.GetComponent<CopyClew>()._clewTo = _clewTo1;
        _script._lauchIndex = 0;
        _lauched = true;

    }
}
