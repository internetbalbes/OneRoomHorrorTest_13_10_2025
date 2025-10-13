using UnityEngine;

public class PlayerHorizontalRotatement : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 10f;

    private const string MouseX = nameof(MouseX);

    private void Update()
    {
        float mouseX = Input.GetAxis(MouseX);
        Vector3 rotation = new Vector3(0f, mouseX * _sensitivity, 0f);
        transform.Rotate(rotation);
    }
}
