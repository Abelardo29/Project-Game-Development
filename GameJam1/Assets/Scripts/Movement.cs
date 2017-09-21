using UnityEngine;

public class Movement : BaseCbaracter {

    // Use this for initialization
    public Rigidbody rb;
    public float jumpPadForce = 1f;

    void Start () {
        rb = GetComponent<Rigidbody>();
	}

    
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * movementSpeed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (rb.velocity.y < 0.1f && rb.velocity.y > -0.1f)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpForce * jumpPadForce, rb.velocity.z);
            }
        }
    }

    public void OnCollision(Collision collision)
    {
        if (collision.gameObject.name == "JumpPad")
        {
            jumpPadForce = 2f;
        }
    }
}
