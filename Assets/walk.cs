using UnityEngine;

public class walk : MonoBehaviour
{
    public Animator animator;
    bool walking = false;

    public float speed;
    private float move;

    public Rigidbody2D rig;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (move > 0)
        {
            transform.localScale = new Vector2(1, 1);
        }
        if (move < 0)
        {
            transform.localScale = new Vector2(-1, 1);
        }
        
        if (Input.GetKey("d") || Input.GetKey("a") || Input.GetKey("left") || Input.GetKey("right"))
            animator.SetBool("walking", true);

        if (Input.GetKeyUp("d") || Input.GetKeyUp("a") || Input.GetKeyUp("left") || Input.GetKeyUp("right"))
            animator.SetBool("walking", false);

        move = Input.GetAxis("Horizontal");

        rig.linearVelocity = new Vector2(move * speed, rig.linearVelocity.y);
    }
}

