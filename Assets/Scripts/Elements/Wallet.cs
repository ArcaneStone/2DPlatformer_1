using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private ScoreDisplay _scoreDisplay;
    private int _score = 0;

    private void OnEnable()
    {
        GetComponent<CollisionHandler>().OnCoinCollected += CollectCoin;
    }

    private void OnDisable()
    {
        GetComponent<CollisionHandler>().OnCoinCollected -= CollectCoin;
    }

    private void CollectCoin(Coin coin)
    {
        _score += coin.Value;
        _scoreDisplay.UpdateScore(_score);
    }
}