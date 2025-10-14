using UnityEngine;

public class TargetPositionFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    private void LateUpdate()
    {
        if (_target != null)
        {
            transform.position = _target.position + _offset;
        }
    }
}
