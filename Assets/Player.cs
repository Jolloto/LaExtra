using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody playerRigidbody;
    private float speed = 10f;
    private float forwardInput;

    [SerializeField] private GameObject focalPointGameObject;

    private void Awake()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        Movement();

    }
    
    private void Movement()
    {
        forwardInput = Input.GetAxis("Vertical");
            
        playerRigidbody.AddForce(focalPointGameObject.transform.forward *  speed * forwardInput);
            
    }
    
    
   
    
}

