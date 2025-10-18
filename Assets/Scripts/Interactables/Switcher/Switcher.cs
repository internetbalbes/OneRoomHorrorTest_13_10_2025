using UnityEngine;

public class Switcher : MonoBehaviour, IInteractable
{
    [SerializeField] private bool _isSwitched;
    internal bool IsSwitched => _isSwitched;

    internal event System.Action<bool> Switched;

    private void Start()
    {
        Switched?.Invoke(_isSwitched);
    }
    
    public void Interact()
    {
        _isSwitched = !_isSwitched;
        Switched?.Invoke(_isSwitched);
    }
}
