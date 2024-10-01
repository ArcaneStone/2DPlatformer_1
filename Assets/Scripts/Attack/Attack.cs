using UnityEngine;

public class Attack : MonoBehaviour
{
    public float Damage { get; protected set; }   

    public void AttackTarget(Health targetHealth)
    {
        targetHealth.TakeDamage(Damage);
    }

    public void SetDamage(float newDamage)
    {
        Damage = newDamage;
    }
}
