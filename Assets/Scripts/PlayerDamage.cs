using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public int damageAmount = 50;

    void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = other.GetComponent<PlayerHealth>();

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damageAmount);
        }
    }
}
