using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    private LifeManager lifeSystem;

    /* Reflect the damage to the health bar */
    public HealthBar healthBar;

    public void Start()
    {
        currentHealth = maxHealth;
        /* Start with max health in the bar */
        healthBar.SetMaxHealth(maxHealth);
        lifeSystem = FindObjectOfType<LifeManager>();

    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if(currentHealth < 0)
        {
            // End game
            lifeSystem.TakeLife();
        }

        // Else update health bar here
        // bar.setValue(-10)
        Debug.Log("current health : " + currentHealth);
    }
    public void AddHealth(int amount)
    {
        currentHealth = currentHealth + amount > 100 ? 100 : currentHealth + amount;

        // Update health bar here
        // bar.setValue(10);
        Debug.Log("current health : " + currentHealth);
    }
}
