using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    public delegate void OnCoinCollectedHandler(Coin coin);
    public static event OnCoinCollectedHandler OnCoinCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Wallet>() != null)
        {
            OnCoinCollected?.Invoke(this);

            Destroy(gameObject);
        }
    }
}
