using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationExamples : MonoBehaviour
{
    [SerializeField] Vector3 vector3 = new Vector3(20f, 0f, 0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(vector3.x * Time.deltaTime, vector3.y * Time.deltaTime, vector3.z * Time.deltaTime);
    }
}
