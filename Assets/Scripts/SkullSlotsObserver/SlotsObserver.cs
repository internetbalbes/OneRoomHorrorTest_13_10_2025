using UnityEngine;

public abstract class SlotsObserver : MonoBehaviour
{
    [SerializeField] protected Slot[] _slots;

    internal event System.Action AllSlotsFilled;

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
