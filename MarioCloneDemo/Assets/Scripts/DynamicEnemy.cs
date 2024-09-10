using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicEnemy : MonoBehaviour
{

    [SerializeField] float moveSpeed = 2;

    Vector2 direction = Vector2.left;

    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TurnCollider")
        {
            direction = -direction;
            sr.flipX = !sr.flipX;
        }
    }
}
