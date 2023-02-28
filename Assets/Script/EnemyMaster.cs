using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMaster : MonoBehaviour
{
    
    public GameObject Player;
    public float Distance;
    public bool isAngered;
    public NavMeshAgent _agent;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Distance = Vector3.Distance(Player.transform.position, this.transform.position);

        if(Distance <=15)
        {
            isAngered = true;
        }
         if(Distance > 10f)
        {
            isAngered = false;
        }
         if(isAngered)
        {
            _agent.isStopped = false;

            _agent.SetDestination(Player.transform.position);
        }
           if(!isAngered)
        {
          _agent.isStopped = true;
        }

        
    }

    
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("test");
           // Destroy(gameObject);
        }
    }

}
