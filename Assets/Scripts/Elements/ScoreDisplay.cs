using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshPro _scoreText;

    private int _score = 0;

    public void UpdateScore(int newScore)
    {
        _score = newScore;
        _scoreText.text = _score.ToString();
    }
}
