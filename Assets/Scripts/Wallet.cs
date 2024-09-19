using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private TextMesh _scoreText;

    private int _score = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Coin>(out Coin coin))
        {
            CollectCoin(coin);
        }
    }

    private void CollectCoin(Coin coin)
    {
        _score += coin.Value;

        _scoreText.text = _score.ToString();
    }
}
