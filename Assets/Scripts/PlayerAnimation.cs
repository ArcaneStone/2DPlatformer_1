using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private static readonly int RunHash = Animator.StringToHash("Run");

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
}
