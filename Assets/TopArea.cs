using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopArea : MonoBehaviour
{
 void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
