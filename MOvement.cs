using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOvement : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D rb;
    Vector2 move;
    Vector2 x;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        move.y = Input.GetAxisRaw("Vertical");
        x.x = speed;
    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * movespeed * Time.fixedDeltaTime);
        rb.AddForce(x);
    }
}
