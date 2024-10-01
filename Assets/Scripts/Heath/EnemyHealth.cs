using UnityEngine;

public class EnemyHealth : Health
{
    private void Update()
    {
        if (IsDead)
        {
            Destroy(gameObject);
        }
    }
}
