using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] protected float _damage;

    protected Health _health;
    protected Attack _attack;

    private void Awake()
    {
        _health = GetComponent<Health>();
        _attack = GetComponent<Attack>();

        _attack.SetDamage(_damage);
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Character>(out Character targetCharacter) && targetCharacter != this)
        {
            _attack.AttackTarget(targetCharacter.GetComponent<Health>());
        }
    }
}
