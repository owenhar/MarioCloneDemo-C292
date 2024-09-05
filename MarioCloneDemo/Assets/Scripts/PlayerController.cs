using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpForce;

    private Rigidbody2D rb;

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
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
