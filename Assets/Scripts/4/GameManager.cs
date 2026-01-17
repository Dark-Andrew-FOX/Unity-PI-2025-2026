using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [Range(0f, 2f)]
    public float timeScale = 1f;

    public List<AudioData> audioDatas = new List<AudioData>();

    public void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(Instance);
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    private int score = 0;

    public void AddScore(int score)
    {
        this.score += score;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = timeScale;
    }
}

[Serializable]
public class AudioData
{
    public int levelNumber;
    public AudioClip clip;
    public float bitLength;
}