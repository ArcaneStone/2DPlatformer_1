using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private static readonly int RunHash = Animator.StringToHash("Run");
    private static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] private Animator _animator;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private PlayerMover _playerMover;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _inputManager = GetComponent<InputManager>();
        _playerMover = GetComponent<PlayerMover>();
    }

    private void Update()
    {
        PlayAttack(_inputManager.IsAttackPressed);
        PlayMove(_playerMover.HorizontalMovement);
    }

    public void PlayMove(float horizontalInput)
    {
        float coefficient = 0.1f;

        _animator.SetBool(RunHash, Mathf.Abs(horizontalInput) > coefficient);
    }

    public void PlayAttack(bool isAttack)
    {
        _animator.SetBool(AttackHash, isAttack);
    }
}
