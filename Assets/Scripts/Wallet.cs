using UnityEngine;

public class Wallet : MonoBehaviour
{
    private int _score = 0;
    private int _value = 1;

    private void Awake()
    {
        Coin.OnCoinCollected += HandleCoinCollected;
    }

    private void OnDestroy()
    {
        Coin.OnCoinCollected -= HandleCoinCollected;
    }

    private void HandleCoinCollected(Coin coin)
    {
        _score += _value;

        Debug.Log($"Количество монет: {_score}.");
    }
}
