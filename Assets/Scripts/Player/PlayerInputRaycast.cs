using UnityEngine;

public class PlayerInputRaycast : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    internal event System.Action<Collider> RaycastHit;

    private float _raycastRange = 7f;

    private void Update()
    {
        Debug.DrawRay(_camera.transform.position, _camera.transform.forward * _raycastRange, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out RaycastHit hit, _raycastRange))
            {
                RaycastHit?.Invoke(hit.collider);
            }
        }
    }
}
