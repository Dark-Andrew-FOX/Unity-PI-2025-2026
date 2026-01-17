using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class InputExample : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0f, z);

        transform.Translate(Vector3.ClampMagnitude(movement, 1) * speed * Time.deltaTime);
    }
}
