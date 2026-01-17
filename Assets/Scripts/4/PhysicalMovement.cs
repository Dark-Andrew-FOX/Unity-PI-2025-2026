using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMovement : MonoBehaviour
{
    public float speed = 6f;

    [SerializeField] Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = transform.forward * speed;
        }
    }
}
