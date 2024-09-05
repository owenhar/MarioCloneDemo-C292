using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{

    [SerializeField] float distance;
    [SerializeField] float speed;

    private Vector3 startingPosition;
    private bool up = true;


    // Start is called before the first frame update
    void Start()
    {
        startingPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (up && (transform.position.y > (startingPosition.y + distance)))
        {
            up = false;
        } else if ( !up && (transform.position.y < startingPosition.y)) {
            up = true;
        }

        if (up)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        } else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }
    }
}
