using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Plane : MonoBehaviour
{
 
    public int maxHealth = 100;
    public int currentHealth;
 
    public HealthBar healthBar;
 
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }
 
    
 
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
 
    private void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.gameObject.tag == "enemy")
        {
            TakeDamage(33);
        }
    }

    void Update ()
    {
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
            
            if(currentHealth <= 0)
            {
                currentHealth = 0;
                Debug.Log("GAME OVER");
				
            }
        }
    }
}