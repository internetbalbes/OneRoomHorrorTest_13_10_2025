using UnityEngine;

public class SkullSlotsObserver : SlotsObserver, IPuzzleCheck
{
    public event System.Action<bool> Checked;

    public bool IsCorrect { get; private set; }

    protected sealed override void OnSlotFilled()
    {
        CheckSlots();
    }

    private void CheckSlots()
    {
        bool allHaveSkull = true;

        foreach (var slot in _slots)
        {
            if (slot.IsEmpty || slot.ContainedObject.GetComponent<Skull>() == null)
            {
                allHaveSkull = false;
                break;
            }
        }

        if (IsCorrect != allHaveSkull)
        {
            IsCorrect = allHaveSkull;
            Checked?.Invoke(IsCorrect);
        }
    }
}
