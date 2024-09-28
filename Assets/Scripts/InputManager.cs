using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float HorizontalAxis { get; private set; }
    public bool JumpPressed { get; private set; }

    private string _horizontalName = "Horizontal";
    private KeyCode _jumpKey = KeyCode.Space;

    private void Update()
    {
        HorizontalAxis = Input.GetAxis(_horizontalName);
        JumpPressed = Input.GetKeyDown(_jumpKey);
    }
}
