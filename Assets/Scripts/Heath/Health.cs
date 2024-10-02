using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float _maxHealth;

    public bool IsDead { get; protected set; } = false;
    public float CurrentHealth { get; protected set; }
    public float MaxHealth { get; private set; }

    protected virtual void Awake()
    {
        MaxHealth = _maxHealth;
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        CurrentHealth = Mathf.Clamp(CurrentHealth - damageAmount, 0, MaxHealth);

        if (CurrentHealth <= 0 && !IsDead)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        IsDead = true;       
    }
}
