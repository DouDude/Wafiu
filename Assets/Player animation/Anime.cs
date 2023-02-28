using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime : MonoBehaviour
{
    Animator Player;

    void Awake()
    {
        Player = GetComponent<Animator>();
    }

   
    void Update()
    {
        
        Player.SetBool("walking", Input.GetButton("Fire1"));
        Player.SetBool("jumping", Input.GetButton("Jump"));

    }
}
