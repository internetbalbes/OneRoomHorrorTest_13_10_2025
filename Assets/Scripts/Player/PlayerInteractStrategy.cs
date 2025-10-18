using UnityEngine;

[RequireComponent(typeof(PlayerInputRaycast))]
public class PlayerInteractStrategy : MonoBehaviour
{
    private PlayerInputRaycast _playerRaycast;

    private void Awake()
    {
        _playerRaycast = GetComponent<PlayerInputRaycast>();
    }

    private void OnPlayerRaycastHit(Collider collider)
    {
        if (collider.TryGetComponent<IInteractable>(out IInteractable interactable))
        {
            interactable.Interact();
        }
    }
    
    private void OnEnable() => _playerRaycast.RaycastHit += OnPlayerRaycastHit;
    private void OnDisable() => _playerRaycast.RaycastHit -= OnPlayerRaycastHit;
}
