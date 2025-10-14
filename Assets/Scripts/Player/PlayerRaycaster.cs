using UnityEngine;

public class PlayerRaycaster : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    internal event System.Action RaycastCollided;

    private void Update()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.TryGetComponent(out IPlayerRaycastable playerRaycastable))
            {
                RaycastCollided?.Invoke();
            }
        }
    }
}

