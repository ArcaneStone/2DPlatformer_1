using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class HealthKit : Item
{
    public float HealAmount { get; private set; } = 20;
}