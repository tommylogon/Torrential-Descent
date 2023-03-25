using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainDropController : MonoBehaviour
{
    public float pushBackForce = 10f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x < 0f)
        {
            rb.AddForce(Vector2.right * pushBackForce, ForceMode.Impulse);
        }
        else if (transform.position.x > 20f)
        {
            rb.AddForce(Vector2.left * pushBackForce, ForceMode.Impulse);
        }


        float maxSpeed = 50f; // Set the maximum speed here
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, maxSpeed);

        if (transform.position.y < 0f)
        {
            Destroy(gameObject);
        }
    }

}
