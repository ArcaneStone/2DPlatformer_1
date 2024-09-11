using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    private int _value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMover>())
        {
            GameObject.FindObjectOfType<CoinCounter>().GetComponent<CoinCounter>().Collect(_value);

            Destroy(gameObject);
        }
    }
}
