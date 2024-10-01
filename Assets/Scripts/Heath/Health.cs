using UnityEngine;

public class Health : MonoBehaviour
{
    public float CurrentHealth;

    public float MaxHealth { get; protected set; }
    public bool IsDead { get; protected set; } = false;

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    public void TakeDamage(float damageAmount)
    {
        CurrentHealth -= damageAmount;

        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            IsDead = true;
        }
    }

    public void SetMaxHealth(float newMaxHealth)
    {
        MaxHealth = newMaxHealth;
    }
}
