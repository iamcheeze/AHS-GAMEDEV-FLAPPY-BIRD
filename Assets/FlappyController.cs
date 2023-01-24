using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    Rigidbody2D rb;
    public float force;

    public Vector3 upRotation = new Vector3(0, 0, 22.171f);
    public Vector3 downRotation = new Vector3(0, 0, -35);

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.anyKeyDown)
        {
            rb.velocity = Vector2.up * force;
            transform.rotation = Quaternion.Euler(upRotation);
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(downRotation), Time.deltaTime * 2);
    }
}
