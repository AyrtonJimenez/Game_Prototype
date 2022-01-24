using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int maxStamina = 100;
    public int currentStamina;
    public int damage = 10;

    public HealthBar healthBar;
    public HealthBar staminaBar;
    public GameObject deathScreen;

    //[SerializeField]
    //private GameObject playerCharacter;
    private bool deathScreenShown = false;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        currentStamina = maxStamina;
        healthBar.SetMaxHealth(maxStamina);
    }

    void Update()
    {

        if (currentHealth <= 0  && !deathScreenShown)
        {
            PlayerDeath();
            deathScreenShown = true;
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

        if(currentHealth <= 0)
        {
            currentHealth = 0;
        }
    }

    public void LoseStamina(int Stamina)
    {
        currentStamina -= Stamina;

        staminaBar.SetHealth(currentStamina);

        if(currentStamina <= 0)
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
