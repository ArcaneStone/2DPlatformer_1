using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public event System.Action<Coin> OnCoinCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Coin>(out Coin coin))
        {
            OnCoinCollected?.Invoke(coin);
            Destroy(coin.gameObject);
        }
    }
}
