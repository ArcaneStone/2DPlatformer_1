using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    [SerializeField] private CoinCounter _coinCounter;

    private int _value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMover>())
        {
            _coinCounter.Collect(_value);

            Destroy(gameObject);
        }
    }
}
