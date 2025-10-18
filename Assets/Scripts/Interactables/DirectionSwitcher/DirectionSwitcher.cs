using UnityEngine;

public class DirectionSwitcher : MonoBehaviour, IInteractable
{
    [SerializeField] private Directions _direction;

    internal event System.Action Switched;

    private enum Directions
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
