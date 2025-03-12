using UnityEngine;

public class Enemy : Character
{
    public void DestroyEnemy()
    {
        Destroy(gameObject);
    }
}