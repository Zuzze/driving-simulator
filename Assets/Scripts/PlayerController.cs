using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // [SerializeField] float speed = 20.0f;
    [SerializeField] float turnSpeed = 45.0f;
    [SerializeField] GameObject centerOfMass;
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float horsePower = 20000;
    private Rigidbody playerRb;

    // Start is called before the first frame update
    // Awake => Start
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        //playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Move vehicle forward
    // FixedUpdate => Update => LateUpdate
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        // Move forward based on vertical input
        //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        playerRb.AddRelativeForce(Vector3.forward * horsePower * verticalInput);
        
        // Rotate based on horizontal
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }
}
