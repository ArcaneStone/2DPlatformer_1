using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    public System.Action<Coin> Collected;

    public int Value { get; private set; } = 1; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Wallet>() != null)
        {
            Collected?.Invoke(this);

            Destroy(gameObject);
        }
    }
}
