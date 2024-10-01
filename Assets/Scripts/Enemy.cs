using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 20;
    [SerializeField] private float _damage = 10;

    private EnemyHealth _health;
    private EnemyAttack _attack;

    private void Start()
    {
        _health = GetComponent<EnemyHealth>();
        _attack = GetComponent<EnemyAttack>();

        _health.SetMaxHealth(_maxHealth);
        _attack.SetDamage(_damage);

        _health.CurrentHealth = _maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _attack.AttackTarget(player.GetComponent<PlayerHealth>());
            Debug.Log($"У врага осталось :{_health.CurrentHealth} XP");
            Debug.Log($"У игрока осталось :{player.GetComponent<PlayerHealth>().CurrentHealth} XP");
        }
    }
}
