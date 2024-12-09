using UnityEngine;

public class EnemyHealth : Health
{
    private Enemy _enemy;

    protected override void Awake()
    {
        base.Awake();

        _enemy = GetComponent<Enemy>();
    }

    private void OnEnable()
    {
        OnDeath += HandleDeath;
    }

    private void OnDisable()
    {
        OnDeath -= HandleDeath;
    }

    private void HandleDeath()
    {
        if (_enemy != null )
        {
            _enemy.DestroyEnemy();
        }
    }
}
