using UnityEngine;

public class Wallet : MonoBehaviour
{
    public static Wallet Instance { get; private set; }

    [SerializeField] private ScoreDisplay _scoreDisplay;

    private int _score = 0;
    private CollisionHandler _collisionHandler;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

        _collisionHandler = GetComponent<CollisionHandler>();
    }

    private void OnEnable()
    {
        _collisionHandler.OnItemCollected += HandleItemCollected;
    }

    private void OnDisable()
    {
        _collisionHandler.OnItemCollected -= HandleItemCollected;
    }

    private void HandleItemCollected(Item item)
    {
        if (item is Coin coin)
        {
            AddCoins(coin.Value);
        }
    }

    public void AddCoins(int value)
    {
        _score += value;
        _scoreDisplay.UpdateScore(_score);
    }
}