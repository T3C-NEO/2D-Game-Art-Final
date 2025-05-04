using UnityEngine;

public class chompper : MonoBehaviour
{

    public Animator animator;

    public GameObject player;

    int timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (animator.GetBool("omnom") == true)
            animator.SetBool("omnom", false);

        if (!player.active)
            timer += 1;
        if (timer > 90)
        {
            player.transform.position = new Vector2(0, 0);
            player.SetActive(true);
            timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("omnom", true);
        player.SetActive(false);
        timer = 0;
    }
}
