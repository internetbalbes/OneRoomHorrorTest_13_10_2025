using UnityEngine;

public class PlayerInputRaycast : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private float _raycastRange = 7f;

    public event System.Action<Collider> RaycastHit;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out RaycastHit hit, _raycastRange))
            {
                RaycastHit?.Invoke(hit.collider);
            }
        }
    }
}
