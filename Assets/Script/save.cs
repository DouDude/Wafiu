using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public bool isMoving = false;
    public float movementSpeed = 5f;
    public float sprintSpeedMultiplier = 2f;
    private bool isSprinting = false;
    public Rigidbody rb;
    public float jumpAmount = 10;
    public float range = 1f;
    public bool grounded = false;
    public Camera GroundedCam;
    public float horizontalSpeed = 1.0f;
    private bool hasJumped = false;
    float v;
 
    

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        grounded = true;
    }
    void Awake()
    {
   

    }
    // Update is called once per frame
    void Update()
    {
        grounded = true;

        
        if(Input.GetKey(KeyCode.Z))
        {
            transform.position += transform.forward * Time.deltaTime * movementSpeed;
         
        }

        if(Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Time.deltaTime * movementSpeed;
        }

        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Time.deltaTime * movementSpeed;
        }

        if(Input.GetKey(KeyCode.Q))
        {
            transform.position -= transform.right * Time.deltaTime * movementSpeed;
        }

        ShootRaycast();


        
     if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(Vector3.up * jumpAmount, ForceMode.Impulse);
            grounded = false;
        }      


        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(v, h, 0);


         if (Input.GetKeyDown(KeyCode.LeftControl)) {
            isSprinting = true;
        } else if (Input.GetKeyUp(KeyCode.LeftControl)) {
            isSprinting = false;
        }
        

    }

    void ShootRaycast()
    {
        RaycastHit hit;
        if(Physics.Raycast(GroundedCam.transform.position, GroundedCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            
            Target target = hit.transform.GetComponent<Target>();
            
        }
    }


  

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            grounded = true;
        }
    }
}