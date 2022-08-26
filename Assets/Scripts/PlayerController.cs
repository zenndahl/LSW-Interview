using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed;
    [SerializeField] private int initMoney;
    [SerializeField] private int money;

    private Animator _animator;
    private Rigidbody2D _rb;
    private Vector2 movement;

    void Start()
    {
        money = initMoney;
        _animator = GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //handle inputs
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        //set animations
        _animator.SetFloat("Horizontal", movement.x);
        _animator.SetFloat("Vertical", movement.y);
        _animator.SetFloat("Speed", movement.sqrMagnitude);
    }


    void FixedUpdate()
    {
        //move the character
        transform.position += new Vector3(movement.x, movement.y) * speed * Time.deltaTime;
        //_rb.MovePosition(_rb.position + movement * speed);
    }

    //used to change the character's sprites 
    private void LateUpdate()
    {
        
    }

}
