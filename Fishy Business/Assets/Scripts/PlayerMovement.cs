using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    private float _speedX, _speedY;
    public float moveSpeed;

    public Animator animator;

    void Update()
    {
        _speedX = Input.GetAxisRaw("Horizontal");
        _speedY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(_speedX, _speedY).normalized * moveSpeed;
        
        animator.SetFloat("SpeedX", _speedX);
        animator.SetFloat("SpeedY", _speedY);
    }
}
