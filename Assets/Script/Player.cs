using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float MaxHealth = 5;
    public static float Health;
    void Start()
    {
        Health = MaxHealth;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Health -= 1;
        }
    }

    
     public void TakeDamage()
    {
        Health -= 1;
    }

}
