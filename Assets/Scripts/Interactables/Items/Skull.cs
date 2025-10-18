using UnityEngine;

public class Skull : Item
{
    private enum Type { Red, Blue, Green, Yellow, Cyan }
    [SerializeField] private Type _type;
}
