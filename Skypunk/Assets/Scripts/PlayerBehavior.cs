using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float rotateSpeed = 2f;



    private void Start()
    {
        
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
         transform.position += transform.forward * moveSpeed;

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * moveSpeed * 0.5f;

        }
        if (Input.GetKey(KeyCode.Q))
        {
            transform.position -= transform.right * moveSpeed * 0.5f;

        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.position += transform.right * moveSpeed *0.5f;

        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -rotateSpeed, 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, rotateSpeed, 0);

        }
    }
    
    
}
    
