using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private static readonly int RunHash = Animator.StringToHash("Run");
    private static readonly int AttackHash = Animator.StringToHash("Attack");

    [SerializeField] private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Move(float horizontalInput)
    {
        _animator.SetBool(RunHash, Mathf.Abs(horizontalInput) > 0.1f);
    }

    public void Attack(bool isAttack)
    {
        _animator.SetBool(AttackHash, isAttack);
    }
}
