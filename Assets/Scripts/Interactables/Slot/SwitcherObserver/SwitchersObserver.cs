using UnityEngine;

public class SwitchersObserver : MonoBehaviour
{
    [SerializeField] private Switcher[] _switchers;

    internal event System.Action AllSwitchersCorrected;

    private void Start()
    {
        foreach (var switcher in _switchers)
            switcher.Switched += OnSwitched;
    }

    private void OnDisable()
    {
        foreach (var switcher in _switchers)
            switcher.Switched -= OnSwitched;
    }

    private void OnSwitched(bool isSwitched)
    {
        CheckSwitchersCorrectment();
    }
    
    private void CheckSwitchersCorrectment()
    {
        foreach (Switcher switcher in _switchers)
        {
            if (switcher.IsSwitched != switcher.GetComponent<CorrectSwitch>().Value)
                return;
        }

        Debug.Log("AllSwitchersCorrected");
        AllSwitchersCorrected?.Invoke();
    }
}
