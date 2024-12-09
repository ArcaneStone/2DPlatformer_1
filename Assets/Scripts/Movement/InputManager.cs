using UnityEngine;

public class InputManager : MonoBehaviour
{
    private string _horizontalName = "Horizontal";
    private KeyCode _jumpKey = KeyCode.Space;
    private KeyCode _attackKey = KeyCode.W;

    public float HorizontalAxis { get; private set; }
    public bool IsJumpPressed { get; private set; }
    public bool IsAttackPressed { get; private set; }
    
    private void Update()
    {
        HorizontalAxis = Input.GetAxis(_horizontalName);
        IsJumpPressed = Input.GetKeyDown(_jumpKey);
        IsAttackPressed = Input.GetKey(_attackKey);
    }
}
