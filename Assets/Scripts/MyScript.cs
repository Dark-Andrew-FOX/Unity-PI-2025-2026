using UnityEngine;
using UnityEngine.Serialization;

public class MyScript : MonoBehaviour
{
    public int intValue;

    public int health;

    [Header("Default Values")]
    [Space]
    [SerializeField] [Min(150)] private int maxHealth = 100;
    [Tooltip("Это урон, который наносит куб")]
    [SerializeField] private int maxDamage = 20;

    [TextArea]
    public string stringValue;

    public GameObject original;

    private void Awake()
    {
        Debug.Log("Log");
        Debug.LogWarning("LogAA");
        Debug.LogError("{LogAAAAAAAAAAAAAAAAAAAAA}");

        enabled = false;

        health = maxHealth;

        //var spawnedObject = Instantiate(original);
        //spawnedObject.GetComponent<MyScript>().Init(120);

        gameObject.transform.Rotate(new Vector3(30f, 0, 0));

        Debug.Log(maxHealth);

        maxHealth = 0;

        Debug.Log(maxHealth);
    }

    public void Init(int maxHealth)
    {
        this.maxHealth = maxHealth;
    }

    private void OnEnable()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void LateUpdate()
    {

    }

    private void FixedUpdate()
    {

    }

    private void OnDisable()
    {

    }

    private void OnDestroy()
    {

    }

}
