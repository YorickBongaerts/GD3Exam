using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public int HP = 50;
    public float _moveSpeed = 10f;
    private float _jumpSpeed = 500f;

    private float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    private bool _isGrounded = true;
    private bool _isJumping = false;
    public bool LoweredGravity = false;
    private Vector3 _moveDirection;
    private Rigidbody _rb;
    private MaterialsManager _matManager;
    public GameObject _protectionSphere;
    public Animator animator;
    private GameObject _playerModel;
    public Text livesText;
    private ObjectPooler2 pool;
    //UI


    #region Unity
    void Start()
    {
        _rb = this.gameObject.GetComponent<Rigidbody>();
        _matManager = FindObjectOfType<MaterialsManager>();
        _protectionSphere = gameObject.transform.GetChild(1).gameObject;
        _playerModel = gameObject.transform.GetChild(0).gameObject;
        pool = FindObjectOfType<ObjectPooler2>();
        livesText.text = HP.ToString();
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
        //if (ObjectPooler.Instance.poolDictionary["Bullets"].Contains(other.gameObject))
        if (pool.ShootingBullet.Contains(other.gameObject))
        {
            HP--;
            livesText.text = HP.ToString();
            if (HP <= 0)
            {
                StartCoroutine(ScoreSystem.OnGameOver());
            }
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
            animator.SetFloat("WalkingSpeed", 0);
            animator.Play("Jump");
            Jump();
        }
        else if (_isJumping && !LoweredGravity)
        {
            foreach (GameObject power in _matManager._collectedPowers)
            {
                if (power != null && power.GetComponent<MeshRenderer>().sharedMaterial.color == new Color(1,1,1,1))
                {
                    _rb.velocity = new Vector3(0, 1, 0);
                    GravityManager.ChangeGravity(-2f);
                    LoweredGravity = true;
                }
            }
        }
    }
    public void OnPowerInput(InputAction.CallbackContext context)
    {
        foreach (GameObject power in _matManager._collectedPowers)
        {
            if (power != null && power.GetComponent<MeshRenderer>().sharedMaterial.name == "MAT_Brown (Instance)" && _matManager.BrownUses > 0)
            {
                power.GetComponent<BrownPowerupScript>().ApplyExtraPower();
            }
            if (power != null && power.GetComponent<MeshRenderer>().sharedMaterial.color == new Color(0,0,1,1) && _matManager.CanUseBlue)
            {
                if (_matManager.CanUseBlue)
                {
                    _protectionSphere.SetActive(true);
                    StartCoroutine(_matManager.BlueTimer());
                }
            }
        }
    }
    #endregion Input

    void Move()
    {
        if (_moveDirection.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(_moveDirection.x, _moveDirection.z) * Mathf.Rad2Deg;
            float angle = Mathf.SmoothDampAngle(_playerModel.transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            _playerModel.transform.rotation = Quaternion.Euler(0, angle, 0);

            _rb.AddForce(_moveDirection.normalized * _moveSpeed, ForceMode.Acceleration);
        }
        if (!_isJumping)
        {
            animator.SetFloat("WalkingSpeed", _rb.velocity.magnitude);
            Debug.Log(_rb.velocity.magnitude);
        }
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
    //private IEnumerator CheckForLoss()
    //{
    //    if (HP <= 0 && Score < 10)
    //    {
    //        yield return new WaitForEndOfFrame();
    //        SceneManager.LoadScene(2);
    //    }
    //    else if (HP <= 0 && Score >= 0)
    //    {
    //        yield return new WaitForEndOfFrame();
    //        SceneManager.LoadScene(3);
    //    }
    //}
    
}
