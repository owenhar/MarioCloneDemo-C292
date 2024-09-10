using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableController : MonoBehaviour
{
    [SerializeField] int pointValue = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collider Entered");
        if (collision.gameObject.tag == "Player")
        {
            UiManager.Instance.IncreaseScore(pointValue);
            Destroy(gameObject);
        }
    }
}
