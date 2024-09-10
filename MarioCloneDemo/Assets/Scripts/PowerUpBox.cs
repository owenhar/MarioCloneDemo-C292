using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpBox : MonoBehaviour
{

    [SerializeField] float jumpHeight;
    [SerializeField] float rotateSpeed;
    [SerializeField] GameObject toSpawn;
    


    bool isRotating = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * rotateSpeed); 
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.position += new Vector3(0, jumpHeight, 0);
            isRotating = true;
            transform.localScale = new Vector3(2, 2, 2);
            if (toSpawn != null)
            {
                Instantiate(toSpawn, Vector3.zero, Quaternion.identity);
            }
        }
    }
}
