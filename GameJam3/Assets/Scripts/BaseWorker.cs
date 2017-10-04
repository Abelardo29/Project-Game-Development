using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWorker : MonoBehaviour {

    public Vector2 baseCamp;
    public string training = "none";
    public float movementSpeed;
    public GameObject selectedBuilding;

    [HideInInspector]
    public Vector3 goal;

    public Color defaultColor = Color.magenta;

    BaseWorker (string trainingParam) {
        training = trainingParam;
    }

	void Start () {
        transform.position = new Vector3(baseCamp.x, baseCamp.y, 0);
        GetComponent<Renderer>().material.color = defaultColor;
    }
	
	void Update () {
	}

    private void LateUpdate() {
            MoveToLocation(goal);

        //if (selectedBuilding != null) {

        //}
    }

    void MoveToLocation(Vector3 goal) {
        transform.position = Vector3.MoveTowards(transform.position, goal, movementSpeed * Time.deltaTime);
        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);        
    }

    public void MoveToBuilding(GameObject building) {
        goal = building.transform.position;
        //while (Vector3.Distance(transform.position, building.transform.position) > 5) {
            MoveToLocation(building.transform.position);
            //if () ;
        //}
    }

    private void OnCollisionEnter (Collision coll) {
        goal = transform.position;
        GetComponent<MeshRenderer>().enabled = false;
        Debug.Log("Yay");
    }


}