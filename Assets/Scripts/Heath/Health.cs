using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] protected float MaxHealth;

    public event System.Action OnDeath;
    public event System.Action<float> OnHealthChanged;

    public bool IsDead { get; protected set; } = false;
    public float CurrentHealth { get; protected set; }

    public float MaxHealthValue => MaxHealth;

    protected virtual void Awake()
    {
        CurrentHealth = MaxHealth;
    }

    private void ChangeHealth(float amount)
    {
        if (amount == 0)
        {
            return;
        }

        float oldHealth = CurrentHealth;
        CurrentHealth = Mathf.Clamp(CurrentHealth + amount, 0, MaxHealth);

        if (CurrentHealth != oldHealth)
        {
            OnHealthChanged?.Invoke(CurrentHealth);
        }

        if (CurrentHealth <= 0 && !IsDead)
        {
            Die();
        }
    }

    public void TakeDamage(float damageAmount)
    {
        if (damageAmount < 0)
        {
            return;
        }

        ChangeHealth(-damageAmount);
    }

    public void Heal(float healAmount)
    {
        if (healAmount < 0)
        {
            return;
        }

        ChangeHealth(healAmount);
    }


    protected virtual void Die()
    {
        IsDead = true;
        OnHealthChanged?.Invoke(CurrentHealth);
        OnDeath?.Invoke();
    }
}