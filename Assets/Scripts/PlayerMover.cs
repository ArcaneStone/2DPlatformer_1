using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    [SerializeField] private float _jumpForce = 8f;

    [SerializeField] private GroundDetector _groundDetector;
    [SerializeField] private PlayerAnimation _playerAnimation;
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
        _rigidbody2D.velocity = new Vector2(_inputManager.HorizontalAxis * _speed, _rigidbody2D.velocity.y);
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
        _playerAnimation.Move(_inputManager.HorizontalAxis);

        if (_inputManager.JumpPressed && _isGrounded)
        {
            _isJump = true;
        }
    }

    private void Jump()
    {
        _rigidbody2D.AddForce(new Vector2(0, _jumpForce), ForceMode2D.Impulse);
    }
}
