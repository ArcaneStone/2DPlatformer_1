using UnityEngine;

public class PlayerHealth : Health
{
    public PlayerHealth(float maxHealth)
    {
        MaxHealth = maxHealth;
    }

    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    private void OnEnable()
    {
        GetComponent<CollisionHandler>().OnHealthKitCollected += Heal;
    }

    private void OnDisable()
    {
        GetComponent<CollisionHandler>().OnHealthKitCollected -= Heal;
    }

    private void Heal(HealthKit healthKit)
    {
        CurrentHealth += healthKit.HealAmount;
        Debug.Log("Восстановлено здоровья: " + healthKit.HealAmount);
    }
}
