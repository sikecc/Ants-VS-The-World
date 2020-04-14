using UnityEngine;

public class Health : MonoBehaviour
{
    public const int maxHealth = 100;
    public int health = maxHealth;
    // whatever object of health bar
    // public GameObject bar;

    public void Start()
    {
        // get the component
        // bar = getComponent<type>();
    }
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health < 0)
        {
            // End game
        }

        // Else update health bar here
        // bar.setValue(-10)
        Debug.Log("current health : " + health);
    }
    public void AddHealth(int amount)
    {
        health = health + amount > 100 ? 100 : health + amount;

        // Update health bar here
        // bar.setValue(10);
        Debug.Log("current health : " + health);
    }
}
