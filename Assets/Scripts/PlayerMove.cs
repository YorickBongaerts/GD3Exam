using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    private float _moveSpeed = 10f;
    private float _jumpSpeed = 750f;
    private float _GroundHeight;
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
        CheckPlayerHeightFromGround();
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
    void CheckPlayerHeightFromGround()
    {
        Ray ray = new Ray(this.gameObject.transform.position, Vector3.down);
        RaycastHit RaycastHit;
        this.gameObject.GetComponent<Collider>().Raycast(ray, out RaycastHit, 20);
        _GroundHeight = RaycastHit.distance;
        if (_GroundHeight + 1 > 5)
        {
            Debug.Log("slow down");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            _isGrounded = true;
            _isJumping = false;
        }
    }
}
