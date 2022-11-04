using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 15f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // it runs on a fixed timer so better to use physics inside
    void FixedUpdate()
    {


        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        rb.MovePosition(rb.position + Vector2.right * x);

    }




    



}
