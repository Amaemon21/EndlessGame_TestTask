using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    [field: SerializeField] public int Speed { get; private set; }
    [field: SerializeField] public int Delay { get; private set; }
    [field: SerializeField] public int MaxDistance { get; private set; }

    [SerializeField] private Template _template;

    [SerializeField] private bool _isActive = true;

    private Transform _transform;

    private void Awake()
    {
        _transform = transform;

        StartCoroutine(Spawn()); 
    }

    public void SetSpeed(int value)
    {
        if (value >= 0)
            Speed = value;
    }

    public void SetDelay(int value)
    {
        if (value >= 0)
            Delay = value;
    }

    public void SetMaxDistance(int value)
    {
        if (value >= 0)
            MaxDistance = value;
    }

    private void Creation()
    {
        Template template = Instantiate(_template, _transform.position, Quaternion.identity);
        template.Init(Speed, MaxDistance);
    }

    private IEnumerator Spawn()
    {
        while (_isActive)
        {
            yield return new WaitForSeconds(Delay);
            Creation();
        }
    }
}