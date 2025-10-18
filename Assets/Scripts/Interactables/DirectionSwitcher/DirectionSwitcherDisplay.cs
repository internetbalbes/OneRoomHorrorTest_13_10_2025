using UnityEngine;
using DG.Tweening;

public class DirectionSwitcherDisplay : MonoBehaviour
{
    [SerializeField] private DirectionSwitcher _directionSwitcher;
    [SerializeField] private GameObject _displayObject;

    private void OnEnable() => _directionSwitcher.Switched += OnSwitched;
    private void OnDisable() => _directionSwitcher.Switched -= OnSwitched;

    private void OnSwitched()
    {
        _displayObject.transform.DORotate(
        new Vector3(0, _displayObject.transform.eulerAngles.y + 90, 0),
        1f,
        RotateMode.FastBeyond360
        ).SetEase(Ease.InOutSine);
    }
}
