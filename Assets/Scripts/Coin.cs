using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    public int Value { get; private set; } = 1;

    private void Start()
    {
        GetComponent<CollisionHandler>().OnCoinCollected += (coin) => {};
    }
}
