using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;
    private float _speedX, _speedY;
    public float moveSpeed;

    /*
    private bool _isMoving;
    private bool _facesRight = true;
    private bool _facesLeft;
    */

    void Update()
    {
        _speedX = Input.GetAxisRaw("Horizontal");
        _speedY = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(_speedX, _speedY).normalized * moveSpeed;

        /*
        if (_speedX != 0 || _speedY != 0)
            _isMoving = true;
        else
            _isMoving = false;

        if (_speedX > 0)
        {
            _facesRight = true;
            _facesLeft = false;
        }
        else if (_speedX < 0)
        {
            _facesRight = false;
            _facesLeft = true;
        }
        */
    }
}
