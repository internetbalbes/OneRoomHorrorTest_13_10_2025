using UnityEngine;

public abstract class InteractableItem : MonoBehaviour, IInteractable
{
    public bool IsHeld { get; set; }

    public void Interact()
    {
        if (IsHeld) return;
        if (IsHeld == false) return;
    }

    private void PickUp()
    {
        
    }
    
    private void PutDown()
    {
        
    }
}
