using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public event System.Action<Item> OnItemCollected;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Item>(out Item item))
        {
            item.Collect();
            OnItemCollected?.Invoke(item);
        }
    }
}