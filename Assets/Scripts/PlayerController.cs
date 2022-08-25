using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int initMoney;
    [SerializeField] private int money;

    private bool isFacingRight = true;
    private bool isFacingDown = true;
    private Animator _animator;
    [SerializeField] private Rigidbody2D _rb;
    private Vector2 _moveDirection;

    void Start()
    {
        money = initMoney;
        _animator = GetComponent<Animator>();
        //_rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //Process Inputs
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        _moveDirection = new Vector2(moveX, moveY).normalized;
    }


    void FixedUpdate()
    {
        Move();
    }

    //used to change the character's sprites 
    private void LateUpdate()
    {
        
    }

    private void Move()
    {
        _rb.velocity = new Vector2(_moveDirection.x * speed * Time.deltaTime, _moveDirection.y * speed * Time.deltaTime);

        //set walking animations

    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector2 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }
}
