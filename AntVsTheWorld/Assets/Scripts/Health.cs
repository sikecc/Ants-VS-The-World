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
        health -= 10;
        if(health < 0)
        {
            // End game
        }

        // Else update health bar here
        // bar.setValue(-10)
    }
    public void AddHealth(int amount)
    {
        health = health + 10 > 100 ? 100 : health + 10;

        // Update health bar here
        // bar.setValue(10);
        Debug.Log("current health : " + health);
    }
}
