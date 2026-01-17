using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;

public class UnityEventsExample : MonoBehaviour
{
    public UnityEvent onDoorOpened;
    public UnityEvent<string> onDamageTaken;

    // Start is called before the first frame update
    void Start()
    {
        //onDoorOpened.AddListener(SimpleMethod);
        //onDoorOpened.Invoke();

        //onDoorOpened.RemoveListener(SimpleMethod);
        //onDoorOpened.Invoke();

        //onDamageTaken.AddListener(DoSomething);
        //onDamageTaken.Invoke("Lava");

        int counter = 0;

        for (int i = 0; i < 10; i++)
        {
            int copy_i = i;
            onDamageTaken.AddListener((message) => { Debug.Log($"{copy_i}"); });
        }
    }

    public void SimpleMethod()
    {
        Debug.Log("fired!");
    }

    //public void DoSomething(string message)
    //{
    //    Debug.Log($"{message}");
    //}
}
