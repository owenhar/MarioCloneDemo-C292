using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;
    [SerializeField] int jumpLimit = 1;

    private Rigidbody2D rb;

    private int jumpCounter = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        Move();
    }

    private void Move()
    {
        float moveInput = Input.GetAxis("Horizontal");
        //transform.rotation.z = 0;
        //if (moveInput > 0) // right
        //{
        //    Debug.Log("move right");
        //}
        //else if (moveInput < 0) // left
        //{
        //    Debug.Log("move left");
        //}
        transform.Translate(moveInput * Vector2.right * moveSpeed * Time.deltaTime);
    }

    private void Jump()
    {
        if (jumpCounter < jumpLimit)
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            jumpCounter++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCounter = 0;
    }

    public bool IsJumping()
    {
        return jumpCounter > 0;
    }
}
