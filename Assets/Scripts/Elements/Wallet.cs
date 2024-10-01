using UnityEngine;

public class Wallet : MonoBehaviour
{
    [SerializeField] private ScoreDisplay _scoreDisplay;

    private int _score = 0;
    private CollisionHandler _collisionHandler;

    private void Awake()
    {
        _collisionHandler = GetComponent<CollisionHandler>();
    }

    private void OnEnable()
    {
        _collisionHandler.OnCoinCollected += CollectCoin;
    }

    private void OnDisable()
    {
        _collisionHandler.OnCoinCollected -= CollectCoin;
    }

    private void CollectCoin(Coin coin)
    {
        _score += coin.Value;
        _scoreDisplay.UpdateScore(_score);
    }
}