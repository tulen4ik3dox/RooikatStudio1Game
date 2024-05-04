using UnityEngine;

public class GeneratorClew : MonoBehaviour
{

    public GameObject _RealyClew;
    public GameObject _CopyClew;
    public clew _script;

    void Update()
    {
        transform.position = _RealyClew.transform.position;
        if (_script._lauchCopy && _script._lauchIndex == 0)
        {
            Debug.Log("ÌßÓ");
            GameObject _copy = Instantiate(_CopyClew);
            _copy.transform.position = _RealyClew.transform.position;
            _script._lauchIndex = 1;
        }

        
    }
}
