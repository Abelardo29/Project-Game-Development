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
<<<<<<< HEAD:GameJam2/Assets/CameraScroll.cs
        cameraDirection = new Vector3(1, 0, 0);
        cameraSpeed = 0.03f;
=======
>>>>>>> 6ab5344c2588fc36fcf295cf97698419f182c430:GameJam2/Assets/Scripts/CameraScroll.cs
        cameraVelocity = cameraDirection * cameraSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = transform.position + cameraVelocity;
	}
}
