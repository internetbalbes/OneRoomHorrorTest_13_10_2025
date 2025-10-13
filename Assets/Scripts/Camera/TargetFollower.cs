using UnityEngine;

public class TargetFollower : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset;

    private void Update()
    {
        transform.rotation = _target.rotation;
    }

    private void LateUpdate()
    {
        if (_target != null)
        {
            transform.position = _target.position + _offset;
        }
    }
}
