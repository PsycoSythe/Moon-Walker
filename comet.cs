using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class comet : MonoBehaviour
{
    public Rigidbody2D rb;
    Vector2 done;
    public float force;

    // Update is called once per frame
    void Update()
    {
        done.x = force;
        rb.AddForce(done); ;
    }
}
