using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWorker : MonoBehaviour {

    private GameObject selectedWorker, selectedBuilding;

    Color selectedColor = Color.yellow;

	void Start () {
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Physics.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector3.up, out hit);

            if (hit.collider != null && hit.collider.gameObject.tag == "Worker" && selectedWorker == null) {
                selectedWorker = hit.collider.gameObject;
                selectedWorker.GetComponent<Renderer>().material.color = selectedColor;
			} else if (hit.collider == null) {
                Unselect();
            }
        }


        if (Input.GetMouseButton(1) && selectedWorker != null) {
            RaycastHit hit;
            Physics.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), -Vector3.up, out hit);
            if (hit.collider != null && hit.collider.gameObject.tag == "BuildingTraining") {
                Debug.Log("Moving to building!");
                selectedWorker.GetComponent<BaseWorker>().MoveToBuilding(hit.transform.gameObject);
            } else {
                selectedWorker.GetComponent<BaseWorker>().goal = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }
        }
    }
    

    public void Unselect() {
        selectedWorker.GetComponent<Renderer>().material.color = selectedWorker.GetComponent<BaseWorker>().defaultColor;
        selectedWorker = null;
    }
}
