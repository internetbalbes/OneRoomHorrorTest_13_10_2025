using UnityEngine;
using TMPro;

public class InteractabilityDisplay : MonoBehaviour
{
    [SerializeField] private CameraRaycast _cameraRaycast;
    [SerializeField] private TMP_Text _interactionText;

    private void OnEnable()
    {
        _cameraRaycast.RaycastHit += OnRaycastHit;
        _interactionText.gameObject.SetActive(false);
    }

    private void OnDisable()
    {
        _cameraRaycast.RaycastHit -= OnRaycastHit;
    }

    private void OnRaycastHit(Collider collider)
    {
        if (collider != null && collider.TryGetComponent(out IInteractable _))
            _interactionText.gameObject.SetActive(true);
        else
            _interactionText.gameObject.SetActive(false);
    }
}