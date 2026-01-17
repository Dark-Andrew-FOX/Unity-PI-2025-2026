using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class buttonExample : MonoBehaviour
{

    int score = 0;

    [SerializeField] TextMeshProUGUI textMeshPro;
    [SerializeField] Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(IncreaseScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score++;
        textMeshPro.text = $"Score = {score}";
    }

}
