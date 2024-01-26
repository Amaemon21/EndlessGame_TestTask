using UnityEngine;

public class Template : MonoCache
{
    private int _speed;
    private int _maxDistance;

    private GameObject _gameObject;
    private Transform _transform;

    private void Awake()
    {
        _gameObject = gameObject;
        _transform = transform;
    }

    public void Init(int speed, int maxDistance)
    {
        _speed = speed;
        _maxDistance = maxDistance;
    }

    public override void OnTick()
    {
        _transform.Translate(_transform.forward * _speed * Time.deltaTime);

        if (_transform.position.z >= _maxDistance)
            Destroy(_gameObject);
    }
}