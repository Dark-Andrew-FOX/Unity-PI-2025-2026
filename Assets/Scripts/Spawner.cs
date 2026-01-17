using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] [Min(1)] int count = 100;

    [SerializeField] Vector3 spawnBox = new Vector3(10, 0, 10);

    // Start is called before the first frame update
    void Start()
    {
        if (prefab == null)
        {
            Debug.LogError("prefab == null");
            enabled = false;
        }

        for (int i = 0; i < count; i++)
        {
            Vector3 position = new Vector3(
                Random.Range(-spawnBox.x, spawnBox.x),
                Random.Range(-spawnBox.y, spawnBox.y),
                Random.Range(-spawnBox.z, spawnBox.z)
                );

            GameObject spawned = Instantiate(prefab, position, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
