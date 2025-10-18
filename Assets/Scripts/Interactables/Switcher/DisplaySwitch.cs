using UnityEngine;

public class DisplaySwitch : MonoBehaviour
{
    [SerializeField] private GameObject _candleFlame;
    [SerializeField] private Switcher _switcher;

    private void OnEnable() => _switcher.Switched += OnSwitched;
    private void OnDisable() => _switcher.Switched -= OnSwitched;

    private void OnSwitched(bool isSwitched)
    {
        _candleFlame.SetActive(isSwitched);
    }
}
