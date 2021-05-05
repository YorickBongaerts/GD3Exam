using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    public float _moveSpeed = 10f;
    private float _jumpSpeed = 500f;
    private float _jumpHeight = 6f;
    private float _GroundHeight;
    private bool _isGrounded = true;
    private bool _isJumping = false;
    private bool _loweredGravity = false;
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
        //if (_isJumping && !_loweredGravity)
        //{
        //    _rb.velocity = new Vector3(0, 1, 0);
        //    GravityManager.ChangeGravity(-8f);
        //    _loweredGravity = true;
        //}
        //else
        //{
            Jump();
        //}
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        //GroundReset();
        //Debug.Log(Physics.gravity);
    }
    void Move()
    {
            _rb.AddForce(_moveDirection.normalized * _moveSpeed, ForceMode.Acceleration);
    }
    void Jump()
    {
        if (_isGrounded)
        {
            _isJumping = true;
            _rb.AddForce(this.gameObject.transform.up * _jumpSpeed, ForceMode.Acceleration);
            _isGrounded = false;
        }
    }
    //void GroundReset()
    //{
    //    if (_isGrounded && _loweredGravity)
    //    {
    //        GravityManager.ChangeGravity(8f);
    //        _loweredGravity = false;
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            _isGrounded = true;
            _isJumping = false;
        }
    }
}
