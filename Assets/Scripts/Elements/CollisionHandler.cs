using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public event System.Action<Coin> OnCoinCollected;
    public event System.Action<HealthKit> OnHealthKitCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            OnCoinCollected?.Invoke(coin);
            Destroy(coin.gameObject);
        }
        else if (collision.TryGetComponent<HealthKit>(out HealthKit healthKit))
        {
            OnHealthKitCollected?.Invoke(healthKit);
            Destroy(healthKit.gameObject);
        }
    }
}
