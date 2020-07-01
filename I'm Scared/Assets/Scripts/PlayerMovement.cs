using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    private Vector2 change;
    private Rigidbody2D rb;

    void Start()
    {
        change = new Vector2();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        change.x = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime * 10;
        change.y = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime * 10;
        change = Vector2.ClampMagnitude(change, speed * Time.deltaTime * 10);
        Move();
    }

    void Move()
    {
        rb.velocity = change;
    }
}
