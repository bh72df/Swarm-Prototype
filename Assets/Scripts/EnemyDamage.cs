using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damageAmount = 50;

    void OnTriggerEnter(Collider other)
    {
        EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();

        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damageAmount);
        }
    }
}
