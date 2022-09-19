using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    bool Detected;
    public GameObject Kukksatan;
    Rigidbody RB;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Detected)
        {
            transform.LookAt(Kukksatan.transform.position);
            RB.velocity = (transform.forward * speed);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Detected = true;
        }
    }
}
