using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private float _damage = 25;

    private PlayerHealth _health;
    private PlayerAttack _attack;

    private void Start()
    {
        _health = GetComponent<PlayerHealth>();
        _attack = GetComponent<PlayerAttack>();

        _health.SetMaxHealth(_maxHealth);
        _attack.SetDamage(_damage);

        _health.CurrentHealth = _maxHealth;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Enemy>(out Enemy enemy) && _attack.IsPlayerPunch())
        {
            _attack.AttackTarget(enemy.GetComponent<EnemyHealth>());
            Debug.Log($"У игрока осталось :{_health.CurrentHealth} XP");
            Debug.Log($"У врага осталось :{enemy.GetComponent<EnemyHealth>().CurrentHealth} XP");
        }
    }
}
