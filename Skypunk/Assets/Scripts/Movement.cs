using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public float movement;

    public float rotateSpeed = 0.1f;
    private float rotate;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Vertical");
        rotate = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * movement * speed);
        transform.Rotate(0, rotate * rotateSpeed, 0);
    }

    

}
