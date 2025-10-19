using UnityEngine;

public abstract class SlotsObserver : MonoBehaviour
{
    [SerializeField] protected Slot[] _slots;

    private void Start()
    {
        if (_slots.Length == 0) return;

        foreach (var slot in _slots)
        {
            slot.Filled += OnSlotFilled;
        }
    }

    private void OnDisable()
    {
        if (_slots.Length == 0) return;
        
        foreach (var slot in _slots)
        {
            slot.Filled -= OnSlotFilled;
        }
    }

    protected virtual void OnSlotFilled() { }
}
