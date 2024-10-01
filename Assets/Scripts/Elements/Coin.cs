using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    public int Value { get; private set; } = 1;
}
