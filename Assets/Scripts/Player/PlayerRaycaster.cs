using UnityEngine;

public class PlayerRaycaster : MonoBehaviour
{
    [SerializeField] private Camera _camera;

    private void Update()
    {
        Debug.DrawRay(_camera.transform.position, _camera.transform.forward * 10f, Color.red);

        if (Physics.Raycast(_camera.transform.position, _camera.transform.forward, out RaycastHit hitInfo, 10f))
        {
            Debug.Log($"Hit: {hitInfo.collider.gameObject.name}");
        }
    }
}

