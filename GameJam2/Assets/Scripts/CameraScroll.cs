using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScroll : MonoBehaviour {

    // Use this for initialization
    private Vector3 offset;
    public Vector3 cameraDirection = Vector3.right;
    public float cameraSpeed;
    public Vector3 cameraVelocity;

	void Start () {
        offset = transform.position;
        cameraVelocity = cameraDirection * cameraSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + cameraVelocity;
	}
}
