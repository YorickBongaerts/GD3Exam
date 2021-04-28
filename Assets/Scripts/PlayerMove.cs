using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float _moveSpeed = 10f;
    private float _jumpSpeed = 750f;
    private bool _isGrounded = true;
    private bool _isJumping = false;
    private Vector3 _moveDirection;
    private Rigidbody _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody>();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = new Vector3(context.ReadValue<Vector2>().x, 0, context.ReadValue<Vector2>().y);
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        Jump();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    void Move()
    {
        _rb.AddForce(_moveDirection.normalized * _moveSpeed, ForceMode.Acceleration);
    }
    public void Jump()
    {
        if (_isGrounded)
        {
            _isJumping = true;
            _rb.AddForce(this.gameObject.transform.up * _jumpSpeed, ForceMode.Acceleration);
            _isGrounded = false;
        }
    }
}
