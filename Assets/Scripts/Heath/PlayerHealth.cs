using UnityEngine;

public class PlayerHealth : Health
{
    [SerializeField] private CollisionHandler _collisionHandler;

    private void Awake()
    {
        _collisionHandler = GetComponent<CollisionHandler>();
    }

    private void OnEnable()
    {
        _collisionHandler.OnHealthKitCollected += Heal;
    }

    private void OnDisable()
    {
        _collisionHandler.OnHealthKitCollected -= Heal;
    }

    private void Heal(HealthKit healthKit)
    {
        CurrentHealth += healthKit.HealAmount;
    }
}
