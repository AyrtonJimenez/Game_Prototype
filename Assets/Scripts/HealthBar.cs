using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    public Slider staminaSlider;

    public void SetMaxHealth(int health)
    {
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    public void SetHealth(int health)
    {
        healthSlider.value = health;
    }

    public void SetStamina(int stamina)
    {
        healthSlider.maxValue = stamina;
        healthSlider.value = stamina;
    }

    public void SetMaxStamina(int stamina)
    {
        healthSlider.value = stamina;
    }
}
