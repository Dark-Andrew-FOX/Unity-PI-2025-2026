using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBoxSpawner : MonoBehaviour
{
    [SerializeField] GameObject dialogBox;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Spawn), 1f);
    }

    public void Spawn()
    {
        Instantiate(dialogBox, transform).GetComponent<DialogBox>().Initialize("DialogBox Title", "DialogBox message. Press ok").AddListener(InputRecieved);
    }

    public void InputRecieved(bool isOk)
    {
        Debug.Log(isOk);
    }
}