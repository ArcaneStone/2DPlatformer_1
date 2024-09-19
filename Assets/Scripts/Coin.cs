using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Coin : MonoBehaviour
{
    public System.Action<Coin> Collected;

    private int _value = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Wallet>() != null)
        {
            Collected?.Invoke(this);

            Destroy(gameObject);
        }
    }

    public int GetValue()
    {
        return _value;
    }
}
