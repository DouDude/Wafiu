using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteractable : MonoBehaviour, IInteractable {

    [SerializeField] private string interactText;
    public int childCount = 0;
    public int totalChildren = 12;
   
    private UnityEngine.AI.NavMeshAgent navMeshAgent;

    private void Awake() {
    
     navMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void Update()
    {
        if (childCount >= totalChildren)
        {
            
            EndGame();
        }
        
    }

    public void Interact(Transform interactorTransform) {
        childCount++;
        
        SetDestination(new Vector3(1.0f, 0.0f, 2.0f));
        float playerHeight = 1.7f;
       
    }

    public void SetDestination(Vector3 destinationPoint)
    {
        navMeshAgent.SetDestination(new Vector3(-16.0f, 3.0f, 80.0f));
        
    }
    
  public string GetInteractText() {
        return interactText;
    }

    public Transform GetTransform() {
        return transform;
    }

    void EndGame()
    {
        
        
    }

}