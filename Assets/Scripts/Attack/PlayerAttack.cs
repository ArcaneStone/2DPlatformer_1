using UnityEngine;

public class PlayerAttack : Attack
{
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private PlayerAnimation _playerAnimation;

    private void Update()
    {
        _playerAnimation.Attack(_inputManager.IsAttackPressed);
    }

    public bool IsPlayerPunch()
    {
        return _inputManager.IsAttackPressed;
    }
}
