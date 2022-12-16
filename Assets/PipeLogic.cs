using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLogic : MonoBehaviour
{
    Rigidbody2D rb;
    public float randPosY = 2.17f;
    public float speed;

    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        transform.position = new Vector3(transform.position.x, Random.Range(randPosY, -randPosY));
    }

    void Update()
    {
        rb.velocity = Vector2.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Completed"))
        {
            transform.position = new Vector3(9.28f, Random.Range(randPosY, -randPosY));
        }
    }
}
