using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeBuilder : BuildMechanic {

    private GameObject ropeSelected;

	// Use this for initialization
	void Start () {
        name = "Rope";
	}
	
	// Update is called once per frame
	public override void UpdateAttachment () {
        base.UpdateAttachment();
		if (Input.GetMouseButtonDown(0)) {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null && hit.collider.gameObject.tag == "Platform" || hit.collider.gameObject.tag == "Support") {
                if (hit.collider.gameObject.tag == "Platform")
                    ropeSelected = hit.collider.gameObject.transform.parent.gameObject;
                else
                    ropeSelected = hit.collider.gameObject;
            }
        }
	}

    protected override void CreateTerrain() {
        if (ropeSelected != null) {
            ropeSelected.GetComponentInChildren<DistanceJoint2D>().distance += 0.1f;
        }
        if (Input.GetMouseButtonDown(1))
            ropeSelected.GetComponentInChildren<DistanceJoint2D>().distance = 0.8f;
    }
}
