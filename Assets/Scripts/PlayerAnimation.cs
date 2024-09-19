using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animator;

    private const string Run = nameof(Run);

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void Move(float horizontalInput)
    {
        if (Mathf.Abs(horizontalInput) > 0.1f)
        {
            _animator.SetBool(Run, true);
        }
        else
        {
            _animator.SetBool(Run, false);
        }
    }
}
