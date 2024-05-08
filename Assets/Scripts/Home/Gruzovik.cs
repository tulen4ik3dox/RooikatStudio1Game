using UnityEngine;

public class Gruzovik : MonoBehaviour
{
    public float _speed;
    public CatWithGruz _script;

    private void Update()
    {
        if (_script._ok)
        {
            transform.position += transform.right * _speed * -1 * Time.deltaTime;
        }
    }
}
