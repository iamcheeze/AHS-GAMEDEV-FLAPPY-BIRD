using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    public Vector3 upRotation = new Vector3(0, 0, 22.171f);
    public Vector3 downRotation = new Vector3(0, 0, -35);

    // Start is called before the first frame update
    void Start()
    {
        //you don't need "this.gameObject"
        //but I'm just trying to make it more readable for you guys
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            rb.velocity = Vector2.up * speed;
            transform.rotation = Quaternion.Euler(upRotation);
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(downRotation), Time.deltaTime * 2);
    }
}
