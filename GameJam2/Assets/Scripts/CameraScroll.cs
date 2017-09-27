using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {

    // Use this for initialization
    private Vector3 offset;
    public Vector3 cameraDirection;
    public float cameraSpeed;
    public Vector3 cameraVelocity;

	void Start () {
        offset = transform.position;
        cameraDirection = new Vector3(1, 0, 0);
        cameraSpeed = 0.02f;
        cameraVelocity = cameraDirection * cameraSpeed;

	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + cameraVelocity;
	}
}
