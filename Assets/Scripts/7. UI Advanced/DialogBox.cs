using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class DialogBox : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI titleText;
    [SerializeField] TextMeshProUGUI messageText;

    /// <summary>
    /// true - ok, false - cancel.
    /// </summary>
    [HideInInspector] public UnityEvent<bool> onMessageBoxInput;

    [SerializeField] bool autoStartTween;

    // Start is called before the first frame update
    void Start()
    {
        if (autoStartTween) StartTween();
    }

    public UnityEvent<bool> Initialize(string title, string message = null)
    {
        titleText.text = title;
        messageText.text = message;

        return onMessageBoxInput;
    }

    public void OkButtonPressed()
    {
        onMessageBoxInput.Invoke(true);
        EndTween();
    }

    public void CancelButtonPressed()
    {
        onMessageBoxInput.Invoke(false);
        EndTween();
    }

    public void StartTween()
    {
        transform.DOScale(new Vector3(), 0.3f).From();
    }

    public void EndTween()
    {
        transform.DOScale(new Vector3(), 0.3f).OnComplete(() => Destroy(gameObject));
    }
}
