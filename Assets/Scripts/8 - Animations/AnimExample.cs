using UnityEngine;

public class AnimExample : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer sprite;
    [SerializeField] BoxCollider2D boxCollider2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            animator.SetTrigger("Attack");
        }

        if (Input.GetKey(KeyCode.A))
        {
            animator.SetInteger("Speed", 1);
            sprite.flipX = true;

        }
        else if (Input.GetKey(KeyCode.D))
        {
            animator.SetInteger("Speed", 1);
            sprite.flipX = false;
        }
        else
        {
            animator.SetInteger("Speed", 0);
        }
    }

    public void SpawnAttackTrigger()
    {
        Debug.Log("SpawnAttackTrigger");
        boxCollider2D.enabled = true;
    }

    public void DisableAttackTrigger()
    {
        Debug.Log("DisableAttackTrigger");
        boxCollider2D.enabled = false;
    }
}
