using UnityEngine;

public class Player : Character
{
    public event System.Action<int> OnCoinCollected;

    [SerializeField] private PlayerAttack _attack;

    protected override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Character>(out Character targetCharacter) && targetCharacter != this)
        {
            AttackCharacter(targetCharacter);
        }
    }

    private void AttackCharacter(Character targetCharacter)
    {
        if (_attack.IsPlayerPunch())
        {
            _attack.AttackTarget(targetCharacter.Health);
        }
    }
}
