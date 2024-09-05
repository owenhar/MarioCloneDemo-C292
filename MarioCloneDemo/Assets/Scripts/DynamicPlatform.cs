using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicPlatform : MonoBehaviour
{
    bool isMoving = false;
    [SerializeField] float moveSpeed = 3;
    [SerializeField] float distance = 5;


    Vector2 direction = Vector2.right;
    Vector3 startingPosition;


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            transform.Translate(direction * moveSpeed * Time.deltaTime);

            if (transform.position.x > distance + startingPosition.x)
            {
                direction = Vector2.left;
            }
            if (transform.position.x < startingPosition.x)
            {
                direction = Vector2.right;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isMoving = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isMoving = false;
        }
    }
}
