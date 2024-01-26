using TMPro;
using UnityEngine;

public class UISettings : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private TMP_InputField _speedInputField;
    [SerializeField] private TMP_InputField _delayInputField;
    [SerializeField] private TMP_InputField _maxDistanceInputField;

    private void Awake()
    {
        UpdateUI();
    }

    public void SetSpeed()
    {
        int.TryParse(_speedInputField.text, out int value);
        _spawner.SetSpeed(value);
        UpdateUI();
    }

    public void SetDelay()
    {
        int.TryParse(_delayInputField.text, out int value);
        _spawner.SetDelay(value);
        UpdateUI();
    }

    public void SetMaxDistance()
    {
        int.TryParse(_maxDistanceInputField.text, out int value);
        _spawner.SetMaxDistance(value);
        UpdateUI();
    }

    private void UpdateUI()
    {
        _speedInputField.text = _spawner.Speed.ToString();
        _delayInputField.text = _spawner.Delay.ToString();
        _maxDistanceInputField.text = _spawner.MaxDistance.ToString();
    }
}