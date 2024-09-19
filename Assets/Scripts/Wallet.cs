using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent<Coin>(out Coin coin))
        {
            CollectCoin(coin);
        }
    }

    private void CollectCoin(Coin coin)
    {
        _score += coin.GetValue();
        Debug.Log($"Количество монет: {_score}.");
    }
}
