using UnityEngine;

public class EnemyHealth : Health
{
    public EnemyHealth(float maxHealth)
    {
        MaxHealth = maxHealth;
    }

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    private void Update()
    {
        if (IsDead)
        {
            Destroy(gameObject);
        }
    }
}
