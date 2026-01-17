using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] EnemyStats stats;

    public float currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = stats.MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
