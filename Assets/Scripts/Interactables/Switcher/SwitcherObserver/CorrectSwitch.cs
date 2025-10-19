using UnityEngine;

public class CorrectSwitch : MonoBehaviour
{
    [SerializeField] private bool _correctValue;
    internal bool Value => _correctValue;
}
