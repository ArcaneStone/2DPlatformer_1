using UnityEngine;

public class Player : Character
{
    [SerializeField]private PlayerAttack _playerAttack;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Character>(out Character targetCharacter) && targetCharacter != this && _playerAttack.IsPlayerPunch())
        {
            _attack.AttackTarget(targetCharacter.GetComponent<Health>());
        }
    }
}
