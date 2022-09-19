using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speedo;
    Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        RB.velocity = transform.forward * Speedo;
    }
}
