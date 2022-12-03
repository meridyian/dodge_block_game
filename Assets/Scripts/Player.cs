using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
  
    public float speed = 15f;
    public float mapWidth = 5f;
    private Rigidbody2D rb;

    public float slowness = 10f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // it runs on a fixed timer so better to use physics inside
    void FixedUpdate()
    {
        // clamp restricts map field

        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);

        rb.MovePosition(newPosition);



    }


    //unity callback function that it decides to call whenever we hit smth

    void OnCollisionEnter2D()
    {
        Time.timeScale = 1f / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;
        FindObjectOfType<GameManager>().EndGame();
    }



}
