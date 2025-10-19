using UnityEngine;

public class CameraRaycast : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _raycastRange = 7f;

    public event System.Action<Collider> RaycastHit;

    private void Update()
    {
        Debug.DrawRay(_camera.transform.position, _camera.transform.forward * _raycastRange, Color.red);

        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out RaycastHit hit, _raycastRange))
        {
            RaycastHit?.Invoke(hit.collider);
        }
    }
}