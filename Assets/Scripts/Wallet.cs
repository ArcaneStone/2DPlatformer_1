using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private TextMesh _scoreText;

    private int _score = 0;

    private void Start()
    {
        GetComponent<CollisionHandler>().OnCoinCollected += CollectCoin;
    }

    private void CollectCoin(Coin coin)
    {
        _score += coin.Value;
        _scoreText.text = _score.ToString();
    }
}
