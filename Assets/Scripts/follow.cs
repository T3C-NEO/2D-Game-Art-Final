using UnityEngine;

public class follow : MonoBehaviour
{

    [SerializeField] private Vector3 offset;
    [SerializeField] private float damping;

    public Transform target;

    private Vector3 vel = Vector3.zero;

    private void FixedUpdate()
    {
        if (target.position.x < 8 && target.position.x > -8)
        {
            Vector3 targetPosition = target.position + offset;
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref vel, damping);
        }
    }
}
