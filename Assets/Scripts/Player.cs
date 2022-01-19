using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int maxStamina = 10;
    public int currentStamina;
    public int maxHealth = 100;
    public int currentHealth;
    public int damage = 10;

    public HealthBar healthBar;
    
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {
            TakeDamage(10);
        }
        if(Input.GetKeyDown(KeyCode.X))
        {
            AddHealth(10);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void AddHealth(int health)
    {
        currentHealth += health;

        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    public void LoseStamina(int Stamina)
    {

    }

    public void ReplenishStamina(int Stamina)
    {

        
    }

    public void PlayerDeath()
    {
        if(currentHealth <= 0)
        {
            
        }
    }
}
