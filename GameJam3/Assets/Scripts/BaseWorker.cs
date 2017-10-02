using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWorker : MonoBehaviour {

    public Vector2 baseCamp;
    public string training = "none";

    [HideInInspector()]
    public Vector2 playerOrders; //a position to be set by the mouse.

	// Use this for initialization
	void Start () {
        transform.position = new Vector3(baseCamp.x, baseCamp.y, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void moveTo(Vector2 goal) {

    }
}
