using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    [SerializeField] private float _speed = 5f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        _rigidbody.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxisRaw(Horizontal);
        float moveVertical = Input.GetAxisRaw(Vertical);

        Vector3 movement = (transform.forward * moveVertical + transform.right * moveHorizontal).normalized;

        _rigidbody.MovePosition(transform.position + movement * _speed * Time.deltaTime);
    }
}
