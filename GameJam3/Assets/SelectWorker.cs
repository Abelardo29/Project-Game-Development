using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWorker : MonoBehaviour {

    private GameObject selectedWorker;


	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject.tag == "Worker" && selectedWorker != null) {
                selectedWorker = hit.collider.gameObject;
                selectedWorker.GetComponent<Renderer>().material.color = Color.yellow;
            }
        }
    }

    public void Unselected() {

    }
}
