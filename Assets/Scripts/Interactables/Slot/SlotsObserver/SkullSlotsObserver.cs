using UnityEngine;

public class SkullSlotsObserver : SlotsObserver
{
    internal event System.Action SlotsFilledCorrectly;

    protected sealed override void OnSlotFilled()
    {
        foreach (var slot in _slots)
        {
            if (slot.IsEmpty) return;

            if (slot.ContainedObject.GetComponent<Skull>() == null) return;

            SlotsFilledCorrectly?.Invoke();
        }
    }
}
