using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public float Health = 100f;
    public float MaxHealth = 100f;
    public Vector3 respawnPositions;

    public void TakeDamage(float damage)
    {
        Health -= damage;
        if (Health <= 0)
        {
            Die();
        }
    }

    public void Heal(float amount)
{
    Health += amount;
    if (Health > MaxHealth)
    {
        Health = MaxHealth;
    }
}

    void Die()
    {
    
        transform.position = Vector3.zero;
        
    
        Health = MaxHealth;

      
    }
}