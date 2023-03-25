using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public float mass = 1f;
    public float pushBackForce = 10f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 movement = new Vector2(horizontalInput * speed, 0f);
        rb.AddForce(movement * mass);

        if (transform.position.x < 0f)
        {
            rb.AddForce(Vector2.right * pushBackForce, ForceMode.Impulse);
        }
        else if (transform.position.x > 20f)
        {
            rb.AddForce(Vector2.left * pushBackForce, ForceMode.Impulse);
        }

        float maxSpeed = 10f; // Set the maximum speed here
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);
    }
}
