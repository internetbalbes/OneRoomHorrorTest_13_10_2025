using UnityEngine;

public abstract class SlotsObserver : MonoBehaviour
{
    [SerializeField] protected Slot[] _slots;

    private void Start()
    {
        foreach (var slot in _slots)
        {
            slot.Filled += OnSlotFilled;
        }
    }

    private void OnDisable()
    {
        foreach (var slot in _slots)
        {
            slot.Filled -= OnSlotFilled;
        }
    }

    protected virtual void OnSlotFilled() { }
}
