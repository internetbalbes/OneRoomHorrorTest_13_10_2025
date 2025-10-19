using UnityEngine;

[RequireComponent(typeof(PlayerInputRaycast))]
public class PlayerInteractStrategy : MonoBehaviour
{
    [SerializeField] private GameObject _heldItem;

    private PlayerInputRaycast _playerRaycast;

    private void Awake()
    {
        _playerRaycast = GetComponent<PlayerInputRaycast>();
    }

    private void OnPlayerRaycastHit(Collider collider)
    {
        if (collider.TryGetComponent<IInteractable>(out IInteractable interactable) == false) return;

        if (interactable is InteractableItem)
        {
            if (_heldItem != null) return;

            _heldItem = collider.gameObject;
            
            if (collider.TryGetComponent<TargetPositionFollower>(out TargetPositionFollower _targetPositionFollower))
            {
                _targetPositionFollower.SetTarget(gameObject.transform);
            }
        }
        else if (interactable is Slot)
        {
            if (_heldItem == null) return;

            _heldItem.GetComponent<TargetPositionFollower>().SetTarget(collider.transform);

            collider.GetComponent<Slot>().Put(_heldItem);

            _heldItem = null;
        }
        else
        {
            interactable.Interact();
        }
    }
    
    private void OnEnable() => _playerRaycast.RaycastHit += OnPlayerRaycastHit;
    private void OnDisable() => _playerRaycast.RaycastHit -= OnPlayerRaycastHit;
}
