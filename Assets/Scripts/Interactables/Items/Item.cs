using UnityEngine;

public abstract class Item : MonoBehaviour, IInteractable
{
    public bool IsHeld { get; set; }

    public void Interact()
    {
        if (IsHeld) return;
        if (IsHeld == false) return;
    }
}
