using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
    }

    private void LateUpdate()
    {
        
    }

    // Triggers
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");

        if (other.gameObject.TryGetComponent<HealthComponent>(out HealthComponent healthComponent))
        {
            //healthComponent.RecieveDamage(1000);
            GameManager.Instance.AddScore(10);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTriggerStay");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTriggerExit");
    }

    // Colliders
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay");
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit");
    }
}
