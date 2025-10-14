using UnityEngine;

public class TargetHorizontalRotatementFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void LateUpdate()
    {
        if (_target != null)
        {
            Vector3 eulerRotation = transform.eulerAngles;
            eulerRotation.y = _target.eulerAngles.y;
            transform.eulerAngles = eulerRotation;
        }
    }
}
