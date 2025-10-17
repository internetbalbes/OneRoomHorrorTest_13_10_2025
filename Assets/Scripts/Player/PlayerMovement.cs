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
    }

    private void Update()
    {
        float moveHorizontal = Input.GetAxisRaw(Horizontal);
        float moveVertical = Input.GetAxisRaw(Vertical);

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical).normalized;

        _rigidbody.MovePosition(transform.position + movement * _speed * Time.deltaTime);
    }
}
