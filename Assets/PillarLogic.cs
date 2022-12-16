using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarLogic : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    public float maxYHeight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector3(transform.position.x, Random.Range(2.17f, -2.17f), 0);
    }

    void Update()
    {
        rb.velocity = Vector2.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Completed"))
        {
            transform.position = new Vector3(11.27f, Random.Range(maxYHeight,-maxYHeight), 0);
        }
    }
}
