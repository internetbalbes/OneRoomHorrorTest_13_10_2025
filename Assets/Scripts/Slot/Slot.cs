using UnityEngine;

public class Slot : MonoBehaviour
{
    [SerializeField] private GameObject _containedObject;

    internal bool IsEmpty => _containedObject == null;

    internal event System.Action Filled;

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
