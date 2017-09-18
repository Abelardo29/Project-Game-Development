using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Use this for initialization
    public Rigidbody rb;
    public float speed = 5.0F;
    public float rotationSpeed = 100.0F;

    void Start () {
        rb = GetComponent<Rigidbody>();
	}

    
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (rb.velocity.y < 0.1f && rb.velocity.y > -0.1f)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.velocity = new Vector3(rb.velocity.x, 10f, rb.velocity.z);
            }
        }
    }
}
