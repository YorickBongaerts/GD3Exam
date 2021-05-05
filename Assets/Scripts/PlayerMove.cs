using System;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public int HP = 50;
    public float _moveSpeed = 10f;
    private float _jumpSpeed = 500f;
    private float _jumpHeight = 6f;
    private float _GroundHeight;
    private bool _isGrounded = true;
    private bool _isJumping = false;
    private bool _loweredGravity = false;
    private Vector3 _moveDirection;
    private Rigidbody _rb;
    private MaterialsManager _matManager;

    #region Unity
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody>();
        _matManager = FindObjectOfType<MaterialsManager>();
    }
    void Update()
    {
        Move();
        //GroundReset();
        //Debug.Log(Physics.gravity);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            _isGrounded = true;
            _isJumping = false;
        }
        if (ObjectPooler.Instance.poolDictionary["Bullets"].Contains(other.gameObject))
        {
            HP--;
            StartCoroutine(CheckForLoss());
        }
    }

    
    #endregion Unity

    #region Input
    public void OnMove(InputAction.CallbackContext context)
    {
        _moveDirection = new Vector3(context.ReadValue<Vector2>().x, 0, context.ReadValue<Vector2>().y);
    }
    public void OnJump(InputAction.CallbackContext context)
    {
        if (!_isJumping)
        {
            Jump();
        }
        else if (_isJumping && !_loweredGravity)
        {
            foreach (GameObject power in _matManager._collectedPowers)
            {
                if (power != null || power.GetComponent<MeshRenderer>().material.name == "MAT_White (Instance)")
                {
                    _rb.velocity = new Vector3(0, 1, 0);
                    GravityManager.ChangeGravity(-8f);
                    _loweredGravity = true;
                }
            }
        }

    }
    #endregion Input

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
    private IEnumerator CheckForLoss()
    {
        if (HP <= 0)
        {
            yield return new WaitForEndOfFrame();
            SceneManager.LoadScene(2);
        }
    }
}
