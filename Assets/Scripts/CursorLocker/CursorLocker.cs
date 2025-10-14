using UnityEngine;

public class CursorLocker : MonoBehaviour
{
    [SerializeField] private bool lockCursor = true;

    private void Start()
    {
        UpdateCursorState();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lockCursor = !lockCursor;
            UpdateCursorState();
        }
    }

    private void UpdateCursorState()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
