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
        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            _animator.SetBool(RunHash, true);
        }
        else
        {
            _animator.SetBool(RunHash, false);
        }
    }

    public void Attack(bool isAttack)
    {
        if (isAttack)
        {
            _animator.SetBool(AttackHash, true);
        }
        else
        {
            _animator.SetBool(AttackHash, false);
        }
    }
}
