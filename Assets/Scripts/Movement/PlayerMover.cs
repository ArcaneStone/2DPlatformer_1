using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    public float HorizontalMovement { get; private set; }

    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jumpForce = 8f;

    [SerializeField] private GroundDetector _groundDetector;
    [SerializeField] private InputManager _inputManager;

    private Rigidbody2D _rigidbody2D;

    private bool _isGrounded = false;
    private bool _isJump = false;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        HorizontalMovement = _inputManager.HorizontalAxis;

        _rigidbody2D.velocity = new Vector2(HorizontalMovement * _speed, _rigidbody2D.velocity.y);
        _isGrounded = _groundDetector.IsGrounded();

        if (_isJump)
        {
            Jump();

            _isJump = false;
            _isGrounded = false;
        }
    }

    private void Update()
    {
        if (_inputManager.IsJumpPressed && _isGrounded)
        {
            _isJump = true;
        }
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
    }
}
