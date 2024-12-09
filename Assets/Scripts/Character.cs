using UnityEngine;

[RequireComponent (typeof(Health))]
[RequireComponent(typeof(Attack))]
public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float Damage;

    protected Health Health;
    protected Attack Attack;

    private void Awake()
    {
        Health = GetComponent<Health>();
        Attack = GetComponent<Attack>();

        Attack.SetDamage(Damage);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Character>(out Character targetCharacter) && targetCharacter != this)
        {
            Attack.AttackTarget(targetCharacter.Health);
        }
    }

    public Health GetHealth()
    {
        return Health;
    }
}
