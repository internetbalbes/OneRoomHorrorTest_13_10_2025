using UnityEngine;

public class CameraVerticalRotatement : MonoBehaviour
{
    [SerializeField] private float _sensitivity = 5f;

    [SerializeField] private float _minAngle = -60f;
    [SerializeField] private float _maxAngle = 60f;

    private const string MouseY = nameof(MouseY);

    private void Update()
    {
        float mouseY = Input.GetAxis(MouseY) * _sensitivity;
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x -= mouseY;

        if (eulerRotation.x > 180f)
        {
            eulerRotation.x -= 360f;
        }

        eulerRotation.x = Mathf.Clamp(eulerRotation.x, _minAngle, _maxAngle);
        transform.eulerAngles = eulerRotation;
    }
}
