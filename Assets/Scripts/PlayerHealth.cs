using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;
    public HealthBar healthBar; 


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth); 

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        
        healthBar.SetHealth(currentHealth); 


    }

    void Update()
    {
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("GameOver");
    }
}
