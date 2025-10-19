using UnityEngine;

public class Slot : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject _containedObject;
    internal GameObject ContainedObject => _containedObject;

    internal bool IsEmpty => _containedObject == null;

    internal event System.Action Filled;

    public void Interact()
    {
        
    }

    internal void Put(GameObject obj)
    {
        _containedObject = obj;
        Filled?.Invoke();
    }

    internal GameObject Take()
    {
        GameObject obj = _containedObject;
        _containedObject = null;
        return obj;
    }
}
