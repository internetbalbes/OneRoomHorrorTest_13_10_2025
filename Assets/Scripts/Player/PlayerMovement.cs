using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private CharacterController _characterController;

    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Vector3 direction = new Vector3(Input.GetAxis(Horizontal), 0f, Input.GetAxis(Vertical));
        Vector3 velocity = direction * _speed;
        velocity = transform.TransformDirection(velocity);
        _characterController.Move(velocity * Time.deltaTime);
    }
}
