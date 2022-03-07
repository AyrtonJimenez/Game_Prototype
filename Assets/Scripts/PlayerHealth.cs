using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int maxStamina = 100;
    public int damage = 10;

    public HealthBar healthBar;
    public HealthBar staminaBar;
    public GameObject deathScreen;
    
    private int currentHealth;
    private int currentStamina;

    private bool deathScreenShown = false;

    private void Update()
    {
        if (currentHealth <= 0 && deathScreenShown)
        {
            PlayerDeath();
            deathScreenShown = true;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            TakeDamage(5);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            AddHealth(5);
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            for(int i = maxStamina; i<= 0; i++)
            {
                LoseStamina(5);
            }
        }
    }

    public void AddHealth(int health)
    {
        currentHealth += health;

        healthBar.SetHealth(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    public void LoseStamina(int Stamina)
    {
        currentStamina = currentStamina - Stamina;

        staminaBar.SetHealth(currentStamina);

        if (currentStamina <= 0)
        {
            currentStamina = 0;
        }
    }

    public void ReplenishStamina(int Stamina)
    {
        currentStamina += Stamina;
        staminaBar.SetHealth(currentStamina);
    }

    public void PlayerDeath()
    {
        Destroy(staminaBar);
        Destroy(healthBar);
        Instantiate(deathScreen);
        Debug.Log("Player Died :(");
    }

}
