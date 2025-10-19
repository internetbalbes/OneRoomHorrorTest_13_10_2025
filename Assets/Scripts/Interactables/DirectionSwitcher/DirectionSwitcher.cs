using UnityEngine;

public class DirectionSwitcher : MonoBehaviour, IInteractable
{
    [SerializeField] private Directions _direction;
    internal Directions Direction => _direction;

    internal event System.Action Switched;

    internal enum Directions
    {
        South, North, East, West
    }
    
    public void Interact()
    {
        int current = (int)_direction;
        current = (current + 1) % System.Enum.GetValues(typeof(Directions)).Length;
        _direction = (Directions)current;
        Switched?.Invoke();
    }
}
