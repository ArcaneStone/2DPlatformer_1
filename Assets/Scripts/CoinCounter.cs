using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    private int _score = 0;

    public void Collect(int value)
    {
        _score += value;
        Debug.Log($"Количество монет: {_score}.");
    }
}