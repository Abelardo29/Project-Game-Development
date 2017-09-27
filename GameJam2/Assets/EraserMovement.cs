using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraserMovement : MonoBehaviour {

    // Use this for initialization
    public Vector3 velocity;

	void Start () {
        velocity = new Vector3(0, 0.5f, 0);
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = (transform.position + velocity);
        if (transform.position.y < -2 || transform.position.y > 7)
        {
            velocity *= -1;
        }
	}
}
