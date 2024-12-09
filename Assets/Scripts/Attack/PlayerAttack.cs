using UnityEngine;

public class PlayerAttack : Attack
{
    [SerializeField] private InputManager _inputManager;

    public bool IsPlayerPunch()
    {
        return _inputManager.IsAttackPressed;
    }
}
