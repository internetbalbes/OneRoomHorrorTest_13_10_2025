using UnityEngine;

public class Skull : MonoBehaviour
{
    private enum Type { Red, Blue, Green, Yellow, Cyan }
    [SerializeField] private Type _type;

    private void Start()
    {
        GetComponent<Renderer>().material.color = _type switch
        {
            Type.Red => Color.red,
            Type.Blue => Color.blue,
            Type.Green => Color.green,
            Type.Yellow => Color.yellow,
            Type.Cyan => Color.cyan,
            _ => Color.white
        };
    }
}
