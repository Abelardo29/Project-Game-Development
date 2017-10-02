using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWorker : MonoBehaviour {

    public Vector2 baseCamp;
    public string training = "none";
    public float movementSpeed;

    [HideInInspector()]
    public Vector2 playerOrders; //a position to be set by the mouse.
    public Vector3 goal;

    public BaseWorker (string trainingParam) {
        training = trainingParam;
    }
	// Use this for initialization
	void Start () {
        transform.position = new Vector3(baseCamp.x, baseCamp.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
            goal = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

    private void LateUpdate() {
            MoveToLocation(goal);
    }

    void MoveToLocation(Vector3 goal) {
        transform.position = Vector3.MoveTowards(transform.position, goal, movementSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);
        
    }

    void MoveToBuilding() {

    }
}
