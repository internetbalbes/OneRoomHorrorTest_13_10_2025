using UnityEngine;

public class SwitchersObserver : MonoBehaviour, IPuzzleCheck
{
    [SerializeField] private Switcher[] _switchers;

    public event System.Action<bool> Checked;

    public bool IsCorrect { get; private set; }

    private void OnEnable()
    {
        foreach (var switcher in _switchers)
        {
            switcher.Switched += OnSwitched;
        }

        CheckSwitchers();
    }

    private void OnDisable()
    {
        foreach (var switcher in _switchers)
        {
            switcher.Switched -= OnSwitched;
        }
    }

    private void OnSwitched(bool _)
    {
        CheckSwitchers();
    }

    private void CheckSwitchers()
    {
        bool allCorrect = true;

        foreach (var switcher in _switchers)
        {
            var correctSwitch = switcher.GetComponent<CorrectSwitch>();
            if (correctSwitch == null || switcher.IsSwitched != correctSwitch.Value)
            {
                allCorrect = false;
                break;
            }
        }

        if (IsCorrect != allCorrect)
        {
            IsCorrect = allCorrect;
            Checked?.Invoke(IsCorrect);
        }
    }
}
