using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : Item
{
    public int Value { get; private set; } = 1;

    public override void Collect()
    {
        Destroy(gameObject);
    }
}
