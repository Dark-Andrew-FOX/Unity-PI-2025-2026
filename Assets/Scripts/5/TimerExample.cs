using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //var coroutine = StartCoroutine(Countown(5));

        //StopCoroutine(coroutine);

        Invoke(nameof(SimpleMethod12323), 5f);
        InvokeRepeating(nameof(SimpleMethod12323), 5f, 2f);
    }

    public void SimpleMethod12323()
    {

    }

    IEnumerator Countown(int seconds)
    {
        Debug.Log("Countdown started");

        while (seconds > 0)
        {
            Debug.Log(seconds);
            yield return new WaitForSeconds(4f);
            seconds--;
        }

        Debug.Log("Timer ended");
    }

    IEnumerator SpawnLoop()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(5f);
        }
    }

    public void SpawnEnemy()
    {

    }
}
