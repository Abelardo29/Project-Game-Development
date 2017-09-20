using UnityEngine;

public class BaseCbaracter : MonoBehaviour {

    public float movementSpeed = 2.0f;
    protected float rotationSpeed;
    public float jumpForce = 10f;


    public BaseCbaracter() {
        rotationSpeed = movementSpeed * 20;
    }
}
