using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthObject : MonoBehaviour
{
    public float healAmount = 5f;
    public float hungerAmount = 10f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHp playerHp = other.GetComponent<PlayerHp>();
            if (playerHp != null)
            {
                playerHp.Heal(healAmount);
                Destroy(gameObject);
            }
        }
         if (other.CompareTag("Player"))
        {
           PlayerHunger playerHunger = other.gameObject.GetComponent<PlayerHunger>();
           if (playerHunger != null)
            {
                playerHunger.AddHunger(hungerAmount);
                Destroy(gameObject);
            }
        }
    }
}