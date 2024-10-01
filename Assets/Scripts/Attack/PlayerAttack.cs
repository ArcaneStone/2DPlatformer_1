using UnityEngine;

public class PlayerAttack : Attack
{
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private PlayerAnimation _playerAnimation;

    private bool _isPunch = false;

    public PlayerAttack(float damage)
    {
        Damage = damage;
    }

    private void Update()
    {
        IsPlayerPunch();
        _playerAnimation.Attack(_inputManager.IsAttackPressed);
    }

    public bool IsPlayerPunch()
    {
        if (_inputManager.IsAttackPressed)
        {
            _isPunch = true;
        }
        else
        {
            _isPunch = false;
        }

        return _isPunch;
    }
}
